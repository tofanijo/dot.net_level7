using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson07_01.struct01;

namespace Lesson07_01.@struct
{
    class Program
    { 
        static void Main(string[] args)
        {
            Mokinys mok = new Mokinys();
            Mokinys mok2 = new Mokinys(10, 3, 8);  
            Mokinys mok3 = mok2;
        
            Console.WriteLine(mok.MetinisVidurkis());
            Console.WriteLine(mok2.MetinisVidurkis());
            Console.WriteLine(mok3.MetinisVidurkis());
            Console.ReadLine();
        }
        
    }
}
