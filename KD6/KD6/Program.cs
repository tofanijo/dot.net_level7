using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurti struktūrą Rinkėjas.Rinkėjas
            //turi ID ir požymį, kad prabalsavo.
            //Sukurti rinkėjų sąrašą.Atsitiktiniu
            //būdu į sąrašą pridėti 10 rinkėjų.
            //Parodyti balsavimo statistiką.

            List<Rinkejas> rinkejasPirmaApylinke = new List<Rinkejas>();
            Rinkejas rinkejas = new Rinkejas();

            Random rnd = new Random();
            for (int i = 0; i <= 10; i++)
            {
                rinkejasPirmaApylinke.Add(new Rinkejas(i, Convert.ToBoolean(rnd.Next(2))));
            }
            rinkejas.ParodytiBalsavimoStatistika(rinkejasPirmaApylinke);

            Console.ReadLine();
        }
    }
}
