using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationMeteo
{
    public class IdBase
    {
        public int id { get; set; }
        public int nbData { get; set; }
        public int type { get; set; }
        public ulong data { get; set; }
        public int alarme { get; set; }

        public IdBase(int id,int nbData,int type,ulong data)
        {
            this.id = id;
            this.nbData = nbData;
            this.type = type;
            this.data = data;
            this.alarme = 0;
        }
    }
}
