using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class ExtensionMethods
    {
        public static int ToInt(this String val)
        {
            try
            {
                return Convert.ToInt32(val);
            }
            catch (Exception ex)
            {
                return -1;
            }            
        }
        public static string LEFT(this string val, int digits = 1)
        {
            return val.Substring(0, digits);            
        }
    }
}
