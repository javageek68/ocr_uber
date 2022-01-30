using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uber_ocr
{
    public class ListItem
    {
        public string name = string.Empty;
        public string value = string.Empty;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public ListItem(string name, string value)
        {
            this.name = name;
            this.value = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.name;
        }
    }
}
