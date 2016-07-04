using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevNotes.DotNet.FactoryMethod
{
    public abstract class Product
    {
        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public string ProductCode { get; set; }


        public override string ToString()
        {
            return $"产品名称：{ProductName}；产品编号：{ProductCode}";
        }
    }
}
