using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD2
{
    struct BibliotekosKnyga
    {
        public int skaitytojoID;
        public string knygosPavadinmas;
        public string skaitytojoVardas;
        public DateTime paemimoData;
        

        

        public int dienuPasSkaitytoja()
        {
            return (paemimoData - DateTime.Now);

        }
}
