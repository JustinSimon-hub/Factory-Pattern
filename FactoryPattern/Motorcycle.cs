using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle : ICarFactory
     {
        public int NumberOfTires { get; set; } = 2;

        public void Drive()
        {
            Console.WriteLine("Motorcycle driving!");
        }
    }
}
