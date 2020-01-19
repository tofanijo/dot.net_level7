using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD3
{
    struct Statc
    {
        public int staciakampioNumeris;
        public double staciakampioIlgis;
        public double staciakampioPlotis;

        public Statc(int nr, double ilgis, double plotis)
        {
            staciakampioNumeris = nr;
            staciakampioIlgis = ilgis;
            staciakampioPlotis = plotis;
        }


        public void Plotas()
        {
            Console.WriteLine($"Staciakampio Nr {staciakampioNumeris} plotas yra: {staciakampioIlgis * staciakampioPlotis}");
        }
    }
}
