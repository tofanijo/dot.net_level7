using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurti struktūrą Stačiakampis su
            //laukais ilgis ir plotis. Struktūroje sukurti
            //metodą Plotas(). Sukurti 3
            //kintamuosius stačiakampis1
            //staciakamis3, užpildyti laukus ir išvesti
            //plotus į konsolę.

            Statc staciakampis1 = new Statc(1, 8.2, 3.8);
            Statc staciakampis2 = new Statc(2, 25.3, 4.6);
            Statc staciakampis3 = new Statc(3, 35.2, 5.4);

            staciakampis1.Plotas();
            staciakampis2.Plotas();
            staciakampis3.Plotas();

            Console.ReadLine();


        }
    }
}
