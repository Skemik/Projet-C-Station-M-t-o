using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationMeteo
{

    class IdAlarme : IdBase
    {
        public int idAl { get; set; }
        public int typeAlarme { get; set; }
        public int etat { get; set; }

        public IdAlarme() : base(0, 0, 0, 0)
        {

        }
    }
}
