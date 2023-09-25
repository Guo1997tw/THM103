using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class ArvinSu
    {
        string name;
        string a;

        public static void AAA(string a)
        {
            ArvinSu s = new ArvinSu();
            s.name = "I am Arvin Su";
            Console.WriteLine(s.name);
            Console.WriteLine("New:" + s.name);
        }
    }
}
