using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD5
{
    struct Studentas
    {
        private int trimestras1;
        private int trimestras2;
        private int trimestras3;

        public Studentas(int trim1, int trim2, int trim3)
        {
            trimestras1 = trim1;
            trimestras2 = trim2;
            trimestras3 = trim3;
        }
        public void PirmoTrimestroVidurkis(List<int> trimestras1)
        {
            double resultatas = 0;
            foreach (var item in trimestras1)
            {
                resultatas += item;
            }

            Console.WriteLine("Pirmo trimestro vidurkis: {0:0.00)", (resultatas / trimestras1.Count));
        }
        public void AntroTrimestroVidurkis(List<int> trimestras2)
        {
            double resultatas = 0;
            foreach (var item in trimestras2)
            {
            }
            Console.WriteLine("Pirmo trimestro vidurkis: {0:0.00)", (resultatas / trimestras2.Count));
        }
        public void TrecioTrimestroVidurkis(List<int> trimestras3)
        {
            double resultatas = 0;
            foreach (var item in trimestras3)
            {
                resultatas += item;
            }
            Console.WriteLine("Pirmo trimestro vidurkis: {0:0.00)", (resultatas / trimestras3.Count));
        }

        public void IsvesiMetiniusVidurkius(List<int> trimestras1, List<int> trimestras2, List<int> trimestras3)
        {
            double rezultatas1 = 0;
            double rezultatas2 = 0;
            double rezultatas3 = 0;

            foreach (var item in trimestras1)
                
            {
                rezultatas1 += item;
            }
            rezultatas1 = rezultatas1 / trimestras1.Count;

            foreach (var item in trimestras2)
            {
                rezultatas2 += item;
            }
            rezultatas2 = rezultatas2 / trimestras2.Count;

            foreach (var item in trimestras3)
            {
                rezultatas3 += item;
            }
            rezultatas3 = rezultatas3 / trimestras3.Count;

            Console.WriteLine("Metinis vidurkis: {0:0.00}", (rezultatas1 + rezultatas2 + rezultatas3) /3);
        }

    }
}
