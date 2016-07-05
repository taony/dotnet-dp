using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.DP.AbstractFactory.Products.Intel
{
    public class IntelCpu : AbstractCpu
    {
        public override void Print()
        {
            System.Console.WriteLine("CPU:INTEL");
        }
    }
}
