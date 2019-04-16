using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteinerProblen
{
    public class Point
    {
        double X;
        public double x
        {
            get
            {
                return this.X;
            }
            set
            {
                this.X = value;
            }
        }

        double Y;
        public double y
        {
            get
            {
                return this.Y;
            }
            set
            {
                this.Y = value;
            }
        }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        double Weight;
        public double weight
        {
            get
            {
                return this.Weight;
            }
            set
            {
                this.Weight = value;
            }
        }
    }
}
