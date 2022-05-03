using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houses
{
    internal class Kitchen : IRoom, IPlace
    {
        public Kitchen(string color, double area)
        {
            Color = color;
            Area = area;
        }
        public double Area { get; set; }
        public string Color { get; set; }
    }
}
