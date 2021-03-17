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
        public IdAlarme(int idAl,int type,int etat) : base(0, 0, 0, 0)
        {
            this.idAl = idAl;
            this.type = type;
            this.etat = etat;
        }
    }
}
