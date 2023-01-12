using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoryMethod
{
    class Bird : IAnimals
    {
        public string Sound()
        {
            return "Bird Sound";
        }
    }

}
