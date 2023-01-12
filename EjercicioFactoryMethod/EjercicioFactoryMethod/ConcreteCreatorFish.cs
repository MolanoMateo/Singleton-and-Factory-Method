using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoryMethod
{
    class ConcreteCreatorFish : Creator
    {
        public override IAnimals FactoryMethod()
        {
            return new Fish();
        }
    }

}
