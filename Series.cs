using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Series : Show
    {
        public int Season;
        public int Episode;

        public Series(string n, string h, string d, int s, int e) : base(n, h, d)
        {
            Season = s;
            Episode = e;
        }
        public override string[] GetInfo()
        {
            var info = new string[4];
            info[0] = base.GetInfo()[0];
            info[1] = base.GetInfo()[1];
            info[2] = base.GetInfo()[2];
            info[3] = $"S{Season}E{Episode}";
            return info;
        }
    }
}
