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

            bk.skaitytojoID = 5;
            bk.skaitytojoVardas = "Romanas";
            bk.knygosPavadinmas = "Brisiaus galas";
            bk.paemimoData = new DateTime(2019, 12, 10);

            Console.WriteLine("Skaitytojo ID", bk.skaitytojoID);
            Console.WriteLine("Skaitytojo Vardas", bk.skaitytojoVardas);
            Console.WriteLine("Knygos pavadinimas", bk.knygosPavadinmas);
            Console.WriteLine("Knyga dienu pas skaitytoja", dienuPasSkaitytoja);
        }

    }
}
