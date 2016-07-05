using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.DP.AbstractFactory.Products.Amd
{
    public class AmdCpu : AbstractCpu
    {
        public override void Print()
        {
            System.Console.WriteLine("CPU: AMD ");
        }
    }
}
