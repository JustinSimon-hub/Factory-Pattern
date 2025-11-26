using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static ICarFactory GetVehicle(int tireCount)
        {
            switch (tireCount)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                default:
                    throw new ArgumentException("No vehicle available with the specified number of tires.");
            }
        }
    }
}
