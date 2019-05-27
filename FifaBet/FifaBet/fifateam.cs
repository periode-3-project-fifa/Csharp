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
        public int homescore { get; set; }
        public int awayscore { get; set; }

        public fifateam(int HomeScore, int AwayScore)
        {
            this.homescore = HomeScore;
            this.awayscore = AwayScore;
        }


        public override string ToString()
        {
            return string.Format("{0}, {1}, {2} , {3}", home, away, homescore, awayscore);  

        }

    }
}
