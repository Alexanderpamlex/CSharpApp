using System;
using System.Collections.Generic;
using System.Text;

namespace Geometrus.Lazutkin
{
    public class Square
    {
        private double side;

        public String toString() { return "Кводрат со стороной=" + side; }
        public double getSide()
        {
            return side;
        }

        public void setSide(double side)
        {
            this.side = side;
        }

        public double Area() { return side * side; }
        public double Size() { return side * side * side; }
    }
}
