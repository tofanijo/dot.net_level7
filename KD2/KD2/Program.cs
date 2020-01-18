using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skurti struktura BibliotekosKnyga su
            //laukais ID, pavadinimas,skaitytojo
            //vardas,paemimo data. Strukturoje
            //sukurti metoda, kuris grazina kiek
            //dienu knyga jau pas skaitytoja.
            //Padaryti kintamaji, rezultata isvesti i konsole.

            BibliotekosKnyga bk = new BibliotekosKnyga();

            bk.skaitytojoID = 45;
            bk.skaitytojoVardas = "Romanas";
            bk.knygosPavadinmas = "Brisiaus galas";
            bk.paemimoData = new DateTime(2019,12,10);
            bk.grazinomoData = new DateTime(2019,12,18);

            Console.WriteLine("Skaitytojo ID - {0}", bk.skaitytojoID);
            Console.WriteLine("Skaitytojo Vardas - {0}", bk.skaitytojoVardas);
            Console.WriteLine("Knygos pavadinimas - {0}", bk.knygosPavadinmas);
            Console.WriteLine("Knyga dienu pas skaitytoja  - {0:0}", (bk.grazinomoData - bk.paemimoData).TotalDays);

            Console.ReadLine();
        }

    }
}
