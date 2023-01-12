using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoryMethod
{
    abstract class Creator
    {
        public abstract IAnimals FactoryMethod();
    }
}
