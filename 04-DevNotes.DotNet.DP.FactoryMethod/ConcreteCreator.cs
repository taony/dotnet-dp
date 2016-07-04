using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.FactoryMethod
{
    public class ConcreteCreator:Creator
    {
        public override Product GetProduct()
        {
            return new ConcreteProduct();
        }
    }
}
