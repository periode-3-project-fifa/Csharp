using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace FifaBet
{
    class save
    {
        public string Balance { get; set; }
        public string Name { get; set; }
        public List<save> hometeam { get; set; }
        public List<save> awayteam { get; set; }
        public List<save> bet { get; set; }
    }
}
