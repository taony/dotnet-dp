using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevNotes.DotNet.DP.AbstractFactory.Products;

namespace DevNotes.DotNet.DP.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public  abstract AbstractCpu CreateCpu();

        public abstract AbstractMainboard CreateMainboard();
    }
}
