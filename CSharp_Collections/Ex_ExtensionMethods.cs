using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Collections
{
    public static class Ex_ExtensionMethod
    {
        public static string Reverse_str(this string name)
        {
            char[] chars = name.ToLower().ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = chars.Length - 1; i >= 0; i--)
            {
                sb.Append(chars[i]);
            }
            return sb.ToString();
        }
    }
}
