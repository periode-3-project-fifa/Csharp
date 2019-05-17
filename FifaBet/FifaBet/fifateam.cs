using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FifaBet
{
    public class fifateam
    {
        public string home { get; set; }
        public string away { get; set; }
        public int id { get; set; }
        public int score { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", home, away);  

        }

        

    }
}
