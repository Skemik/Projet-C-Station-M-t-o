using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationMeteo
{
    class IdMesure : IdBase
    {
        public int intervalleMin { get; set; }
        public int intervalleMax { get; set; }
        public int alarmeMin { get; set; }
        public int alarmeMax { get; set; }
        public float dataConverti { get; set; }

        public IdMesure() : base(0,0,0,0)
        {

        }
    }
}
