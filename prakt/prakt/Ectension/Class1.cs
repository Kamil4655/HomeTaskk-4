using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prakt.Ectension
{
    internal static class Class1
    {
        public static string ToCapitolize(this string txt)
        {
            return Char.ToUpper(txt[0])+txt.Substring(1).ToLower();
        }

        public static int Add(this int x, int y) 
        {
            return x + y;
         
        }
       
        
       
        
    }
}
