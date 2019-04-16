using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteinerProblen
{
    public class AlgorithmFFS
    {
        /// <summary>
        /// Максимальный вес рыбки - свободный параметр
        /// </summary>
        double wmax;
        
        /// <summary>
        /// Величина шага перемещения - свободный параметр алгоритма
        /// </summary>
        double vIndMax;

        /// <summary>
        /// Количество итераций алгоритма
        /// </summary>
        int MaxIter;

        /// <summary>
        /// Максимальная величина шага волевого плавания
        /// </summary>
        double vVolMax;

        /// <summary>
        /// Множество точек-агентов: популяцмя
        /// </summary>
        List<Point> population, populationTau, populationKsi, populationt;

        /// <summary>
        /// Количество особей в популяции - свободный параметр
        /// </summary>
        int CountP;

        double weight, weightNext;

        public Graph graph;

        static Random rand = new Random();

        public ProgressBar progress;

        public AlgorithmFFS(int iter, double ind, double vol, int wei, int count)
        {
            this.MaxIter = iter;
            this.vIndMax = ind;
            this.vVolMax = vol;
            this.wmax = wei;
            this.CountP = count;
        }

        /// <summary>
        /// Инициализация популяция
        /// </summary>
        void InitPopulation()
        {
            population = new List<Point>();
            populationTau = new List<Point>();
            populationKsi = new List<Point>();
            weight = 0.0;
            for(int i=0; i<CountP; i++)
            {
                population.Add(new Point(graph.xmin + (graph.xmax - graph.xmin) * AlgorithmFFS.rand.NextDouble(), graph.ymin + (graph.ymax - graph.ymin) * AlgorithmFFS.rand.NextDouble()));
                population[population.Count - 1].weight = wmax / 2;
                populationTau.Add(new Point(0.0, 0.0));
                populationKsi.Add(new Point(0.0, 0.0));
                weight += population[i].weight;
            }
        }

        double Max(double a, double b)
        {
            if (a > b) return a;
            else return b;
        }

        /// <summary>
        /// Оператор кормления
        /// </summary>
        void Feeding(List<Point> t, List<Point> t1)
        {
            for(int i=0; i<CountP; i++)
            {
                population[i].weight += (graph.fitnessFunction(t1[i]) - graph.fitnessFunction(t[i])) / Max(graph.fitnessFunction(t1[i]), graph.fitnessFunction(t[i]));
            }
        }
    
        Point Swimming(Point fish, double vInd)
        {
            Point nextFish = new Point(fish.x, fish.y);
            nextFish.weight = fish.weight;

            nextFish.y += vInd;
            if (graph.fitnessFunction(nextFish) > graph.fitnessFunction(fish))
            {
                nextFish.y -= vInd;
            }
            else
            {
                if (graph.ymax < nextFish.y)
                {
                    nextFish.y -= vInd;
                }
            }

            nextFish.y -= vInd;
            if (graph.fitnessFunction(nextFish) > graph.fitnessFunction(fish))
            {
                nextFish.y += vInd;
            }
            else
            {
                if (graph.ymin > nextFish.y)
                {
                    nextFish.y += vInd;
                }
            }

            nextFish.x += vInd;
            if (graph.fitnessFunction(nextFish) > graph.fitnessFunction(fish))
            {
                nextFish.x -= vInd;
            }
            else
            {
                if (graph.xmax < nextFish.x)
                {
                    nextFish.x -= vInd;
                }
            }

            nextFish.x -= vInd;
            if (graph.fitnessFunction(nextFish) > graph.fitnessFunction(fish))
            {
                nextFish.x += vInd;
            }
            else
            {
                if (graph.xmin > nextFish.x)
                {
                    nextFish.x += vInd;
                }
            }

            return nextFish;
        }

        /// <summary>
        /// Оператор индивидуального плавания
        /// </summary>
        void IndividualSwimming()
        {
            double vInd;
            for (int i=0; i<CountP; i++)
            {
                vInd = AlgorithmFFS.rand.NextDouble() * vIndMax;
                populationTau[i] = Swimming(population[i], vInd);
            }
        }

        /// <summary>
        /// Инстинктивно-коллективное плавание
        /// </summary>
        void CollectiveInstinctSwimming()
        {
            List<Point> Vind = new List<Point>();
            for(int i=0; i<CountP; i++)
            {
                Vind.Add(new Point(populationTau[i].x - population[i].x, populationTau[i].y - population[i].y));
                Vind[i].weight = populationTau[i].weight;
            }

            double newX = 0.0, newY = 0.0, znam = 0.0; 
            for(int i=0; i<CountP; i++)
            {
                
                for(int j=0; j<CountP; j++)
                {
                    newX += Vind[j].x * (graph.fitnessFunction(populationTau[i]) - graph.fitnessFunction(population[i]));
                    newY += Vind[j].y * (graph.fitnessFunction(populationTau[i]) - graph.fitnessFunction(population[i]));
                    znam += (graph.fitnessFunction(populationTau[j]) - graph.fitnessFunction(population[j]));
                }
                newX = newX / znam;
                newY = newY / znam;
                populationKsi[i].x = populationTau[i].x + newX;
                populationKsi[i].y = populationTau[i].y + newY;
                populationKsi[i].weight = populationTau[i].weight;
                newX = 0.0;
                newY = 0.0;
                znam = 0.0;
            }
        }

        /// <summary>
        /// Коллективно-волевое плавание
        /// </summary>
        /// <returns></returns>
        List<Point> CollectiveVolitionSwimming()
        {
            List<Point> res = new List<Point>();
            for(int i=0; i<CountP; i++)
            {
                res.Add(new Point(populationKsi[i].x, populationKsi[i].y));
                res[i].weight = populationKsi[i].weight;
            }

            Point Xc = new Point(0.0, 0.0);
            weightNext=0.0;
            for(int i=0; i<CountP; i++)
            {
                weightNext += populationKsi[i].weight;
            }

            for(int i=0; i<CountP; i++)
            {
                Xc.x += populationKsi[i].weight * populationKsi[i].x / weightNext;
                Xc.y += populationKsi[i].weight * populationKsi[i].y / weightNext;
            }

            double vVol;
            for(int i=0; i<CountP; i++)
            {
                vVol = vVolMax * AlgorithmFFS.rand.NextDouble();
                if(weightNext>weight)
                {
                    res[i].x = res[i].x + vVol;
                    res[i].y = res[i].y + vVol;
                }
                else
                {
                    res[i].x = res[i].x - vVol;
                    res[i].y = res[i].y + vVol;
                }
            }
            return res;
        }

        /// <summary>
        /// Реализация алгоритма
        /// </summary>
        /// <param name="P">Список точек</param>
        /// <returns>Возвращает точку Ферма для заданного набора точек</returns>
        public Point FFS(List<Point> P)
        {
            graph = new Graph(P);
            InitPopulation();
            for(int i=0; i<MaxIter; i++)
            {
                progress.PerformStep();
                IndividualSwimming();
                CollectiveInstinctSwimming();
                populationt = CollectiveVolitionSwimming();
                Feeding(populationt, population);
                for(int j=0; j<CountP; j++)
                {
                    population[j].x = populationt[j].x;
                    population[j].y = populationt[j].y;
                }
                vVolMax = vVolMax / 1.5;
                vIndMax = vIndMax / 1.5;
            }
            Point res = new Point(population[0].x, population[0].y);
            for(int i=1; i<CountP; i++)
            {
                if(graph.fitnessFunction(population[i])<graph.fitnessFunction(res))
                {
                    res.x = population[i].x;
                    res.y = population[i].y;
                }
            }

            return res;
        }
    }
}
