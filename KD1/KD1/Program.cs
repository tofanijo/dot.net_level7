using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sukurti struktura Mokynis su laukais
            //vardas, pavarde, kurso pradzia ir kurso pabaiga.
            //Sukurti kintamaji mokinys uzpildyti
            //laukus ir isvesti i konsole

            Mokynis mok = new Mokynis();
            mok.vardas = "Romanas";
            mok.pavarde = "Tofanas";
            mok.kursoPradzia = new DateTime(2019, 12, 10);
            mok.kursoPabaiga = new DateTime(2020, 02, 15);

            Console.WriteLine("Vardas {0},Pavarde {1}",mok.vardas, mok.pavarde);
            Console.WriteLine("Kurso pradzios data {0}",mok.kursoPradzia.ToShortDateString());
            Console.WriteLine("Kurso pabaiga data {0}", mok.kursoPabaiga.ToShortDateString());

            Console.ReadLine();


        }
    }
}
