using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Rock__Paper__Scissors
{
    class Program
    {
        public static void Main()
        {
            Menu m = new Menu();
            m.menu();

            Console.ReadKey();
        }

    }
}

