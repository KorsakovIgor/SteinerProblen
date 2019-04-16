using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteinerProblen
{
    public class Graph
    {
        /// <summary>
        /// Список точек
        /// </summary>
        List<Point> points;

        public double xmin, xmax, ymin, ymax;

        int count;
        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public Graph(List<Point> points)
        {
            this.points = points;
            this.count = points.Count;
            xmin = xMin();
            xmax = xMax();
            ymin = yMin();
            ymax = yMax();
        }

        /// <summary>
        /// Расстояние между точками двумя
        /// </summary>
        /// <param name="point1">координаты 1 точки</param>
        /// <param name="point2">координаты 2 точки</param>
        /// <returns>Возвращает Евклидово расстояние  между точками</returns>
        public double Distance(Point point1, Point point2)
        {
            return Math.Sqrt((point1.x - point2.x) * (point1.x - point2.x) + (point1.y - point2.y) * (point1.y - point2.y));
        }

        /// <summary>
        /// Вычисление фитнесс-функции от точки
        /// а именно суммы расстояний от нее до всех точек заданнных
        /// </summary>
        /// <param name="point"></param>
        /// <returns>Возвращает значение фитнесс-функции</returns>
        public double fitnessFunction(Point point)
        {
            double res = 0;
            for(int i=0; i<count; i++)
            {
                res += Distance(point, this.points[i]);
            }
            return res;
        }

        double xMax()
        {
            double max=points[0].x;
            for(int i=1; i<count; i++)
            {
                if (points[i].x > max) max = points[i].x;
            }
            return max;
        }

        double yMax()
        {
            double max = points[0].y;
            for (int i = 1; i < count; i++)
            {
                if (points[i].y > max) max = points[i].y;
            }
            return max;
        }

        double xMin()
        {
            double min = points[0].x;
            for (int i = 1; i < count; i++)
            {
                if (points[i].x < min) min = points[i].x;
            }
            return min;
        }

        double yMin()
        {
            double min = points[0].y;
            for (int i = 1; i < count; i++)
            {
                if (points[i].y < min) min = points[i].y;
            }
            return min;
        }
    }
}
