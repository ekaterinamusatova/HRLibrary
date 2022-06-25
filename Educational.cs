using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Educational : Show
    {
        public string Field;

        public Educational(string n, string h, string d, string f) : base(n, h, d)
        {
            Field = f;
        }
        public override string[] GetInfo()
        {
            var info = new string[4];
            info[0] = base.GetInfo()[0];
            info[1] = base.GetInfo()[1];
            info[2] = base.GetInfo()[2];
            info[3] = $"Образовательная передача (область: {Field})";
            return info;
        }
    }
}
