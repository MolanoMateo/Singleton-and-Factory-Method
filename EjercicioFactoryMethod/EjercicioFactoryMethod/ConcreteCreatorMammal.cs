using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoryMethod
{
    class ConcreteCreatorMammal : Creator
    {
        public override IAnimals FactoryMethod()
        {
            return new Mammal();
        }
    }

}
