using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurti struktūrą Studentas.Joje turi
            //būti 3 sąrašai su trimestrų
            //pažymiais.Struktūra turi turėti
            //metodus trimestro vidurkiui ir
            //metiniam pažymiui suskaičiuoti.

            List<int> trimestras1 = new List<int>();
            List<int> trimestras2 = new List<int>();
            List<int> trimestras3 = new List<int>();

            Studentas stut = new Studentas();

            Random rnd = new Random();
            for (int i = 0; i < 11; i++)
            {
                trimestras1.Add(rnd.Next(2, 10));
                trimestras2.Add(rnd.Next(2, 10));
                trimestras3.Add(rnd.Next(2, 10));

            }
            stut.PirmoTrimestroVidurkis(trimestras1);
            stut.AntroTrimestroVidurkis(trimestras2);
            stut.TrecioTrimestroVidurkis(trimestras3);
            stut.IsvesiMetiniusVidurkius(trimestras1, trimestras2, trimestras3);

            Console.ReadLine();

        }
    }
}
