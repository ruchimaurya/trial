using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trial
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = "This is a string.";
            String sub1 = "this";
            Console.WriteLine("Does '{0}' contain '{1}'?", s, sub1);
            StringComparison comp = StringComparison.Ordinal;
            Console.WriteLine("   {0:G}: {1}", comp, s.Contains(sub1, comp));

            comp = StringComparison.OrdinalIgnoreCase;
            Console.WriteLine("   {0:G}: {1}", comp, s.Contains(sub1, comp));
        }
    }
}
