using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteinerProblen
{
    public class FAlgorithm
    {
        public ProgressBar progress;

        /// <summary>
        /// Взаимная привлекательность светлячков при нулевом расстоянии
        /// </summary>
        double beta0;

        /// <summary>
        /// Коэффициет поглощения света средой
        /// </summary>
        double gamma;

        /// <summary>
        /// Свободный параметр радномизации
        /// </summary>
        double alpha;

        static Random rand = new Random();

        public Graph graph;

        /// <summary>
        /// Размер популяции
        /// </summary>
        int CountP;

        /// <summary>
        /// Количество итераций алгоритма
        /// </summary>
        int MaxIter;

        List<Point> population;

        public FAlgorithm(int MaxIt, double B0, double G, double Al, int Pop)
        {
            this.CountP = Pop;
            this.beta0 = B0;
            this.MaxIter = MaxIt;
            this.alpha = Al;
            this.gamma = G;
        }

        /// <summary>
        /// Инициализация популяция
        /// </summary>
        void InitPopulation()
        {
            population = new List<Point>();
            for (int i = 0; i < CountP; i++)
            {
                population.Add(new Point(graph.xmin + (graph.xmax - graph.xmin) * FAlgorithm.rand.NextDouble(), graph.ymin + (graph.ymax - graph.ymin) * FAlgorithm.rand.NextDouble()));
            }
        }

        /// <summary>
        /// Перемещение Светлячков
        /// </summary>
        void FireflyMove()
        {
            for(int i=0; i<CountP; i++)
            {
                for(int j=0; j<CountP; j++)
                {
                    if(graph.fitnessFunction(population[i])>graph.fitnessFunction(population[j]))
                    {
                        double beta = beta0 / (1 + gamma * Math.Pow(graph.Distance(population[i], population[j]), 2));
                        double U = -1 + FAlgorithm.rand.NextDouble() * 2;
                        population[i].x = beta * (population[i].x - population[j].x) + alpha * U;
                        population[i].y = beta * (population[i].y - population[j].y) + alpha * U;
                    }
                }
            }
        }

        /// <summary>
        /// Расчет по алгоритму светлячков
        /// </summary>
        /// <param name="P"></param>
        /// <returns></returns>
        public Point Calculate(List<Point> P)
        {
            graph = new Graph(P);
            InitPopulation();
            for(int i=0; i<MaxIter; i++)
            {
                FireflyMove();
                progress.PerformStep();
            }

            Point res = new Point(population[0].x, population[0].y);
            for (int i = 1; i < CountP; i++)
            {
                if (graph.fitnessFunction(population[i]) < graph.fitnessFunction(res))
                {
                    res.x = population[i].x;
                    res.y = population[i].y;
                }
            }

            return res;
        }
    }
}
