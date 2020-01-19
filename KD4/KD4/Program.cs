using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurti struktūrą Studentas, su
            //laukais ID ir įskaitos rezultatas(bool ).
            //Sukurti studentų sąrašą
            //List<Studentas>, pridėti 5 studentus į
            //sąrašą.Atskiroje funkcijoje išvesti
            //sąrašą į konsolę.

            List<Studentas> studentuSarasas = new List<Studentas>();
            studentuSarasas.Add(new Studentas(1, true));
            studentuSarasas.Add(new Studentas(2, false));
            studentuSarasas.Add(new Studentas(3, true));
            studentuSarasas.Add(new Studentas(4, false));
            studentuSarasas.Add(new Studentas(5, true));

            IsvestiStudentuDuomenis();

            Console.ReadLine();

            void IsvestiStudentuDuomenis()
            {
                foreach (var item in studentuSarasas)
                {
                    Console.WriteLine($"Studento ID: {item.id}, Iskaitos rezultatas: {item.iskaitosRezultatas}");
                }
            }
        }
    }
    }
