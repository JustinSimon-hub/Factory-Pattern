using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public interface ICarFactory
    {
        public int NumberOfTires { get; set; }
        public void Drive();


    }
}



