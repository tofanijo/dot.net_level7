using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07_01.struct01
{
    struct Mokinys
    {
        private int trimestras1;
        private int trimestras2;
        private int trimestras3;
        public Mokinys(int trim1, int trim2, int trim3)
        {
            trimestras1 = trim1;
            trimestras2 = trim2;
            trimestras3 = trim3;
        }

        public int MetinisVidurkis()
        {
            return (trimestras1 + trimestras2 + trimestras3) / 3;
        }
    }
}
