using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD6
{
    struct Rinkejas
    {
        public int id;
        public bool aprabalsavo;

        public Rinkejas (int _id, bool prabalsavo)
        {
            id = _id;
            aprabalsavo = prabalsavo;
        }

        public void ParodytiBalsavimoStatistika(List<Rinkejas> rinkejas)
        {
            foreach(var item in rinkejas)
            {
                Console.WriteLine($"Rinkejo ID: {item.id}, Ar prabalsavo: {item.aprabalsavo}");
            }
        }

        public int Testas(int skaicius)
        {
            int resultatas = skaicius + 10;
            return resultatas;
        }
    }
}
