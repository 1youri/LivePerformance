using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Live_Performance
{
    public static class Extensions
    {
        /// <summary>
        /// De -.ToInt() Variant van ToString, met afvanging voor fouten in de database of dergelijke
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static int ToInt(this object obj)
        {
            try
            {
                return Convert.ToInt32(obj);
            }
            catch (InvalidCastException)
            {
                return -1;
            }

        }
    }
}
