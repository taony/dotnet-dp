using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.Prototype
{
    /// <summary>
    /// 原型
    /// </summary>
    public abstract class Property
    {
        /// <summary>
        /// 克隆
        /// </summary>
        /// <returns></returns>
        public abstract Property Clone();
    }
}
