using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoryMethod
{
    class Fish : IAnimals
    {
        public string Sound()
        {
            return "Fish Sound";
        }
    }

}
