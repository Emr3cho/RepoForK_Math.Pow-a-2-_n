using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houses
{
    internal class Building : IPlace
    {
        public Building(string color, double height, double area)
        {
            Area = area;
            Color = color;
            Height = height;
        }
        public double Area { get; set; }
        public string Color { get; set; }
        public double Height { get; set; }
    }
}
