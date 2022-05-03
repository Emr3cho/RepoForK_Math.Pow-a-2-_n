using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Houses
{
    internal class House : IPlace
    {

        public House(string color, double height, IRoom[] rooms, Person person)
        {
            Color = color;
            Height = height;
            Rooms = rooms;
            Owner = person;
        }
        public double Area { get { return Rooms.Sum(x => x.Area); } }
        public string Color { get; set; }
        public double Height { get; set; }
        public IRoom[] Rooms { get; set; }

        public Person Owner { get; set; }


    }
}
