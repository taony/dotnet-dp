using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.FactoryMethod
{
    public abstract class Creator
    {
        /// <summary>
        /// 创建产品
        /// </summary>
        /// <returns></returns>
        public abstract Product GetProduct();
    }
}
