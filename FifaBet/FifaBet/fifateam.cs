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
        public string name { get; set; }
        public int id { get; set; }
        public int points { get; set; }

        public override string ToString()
        {
            return this.name;
        }
    }
}
