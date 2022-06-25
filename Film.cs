using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Film : Show
    {
        public string Genre;
        public string Director;
        public string Counries;
        public int Year;

        public Film(string n, string h, string d, string g, string dir, string c, int y) : base(n, h, d)
        {
            Genre = g;
            Director = dir;
            Counries = c;
            Year = y;
        }
        public override string[] GetInfo()
        {
            var info = new string[4];
            info[0] = base.GetInfo()[0];
            info[1] = base.GetInfo()[1];
            info[2] = base.GetInfo()[2];
            info[3] = $"Жанр: {Genre}. Режиссёр: {Director}. Страна/страны: {Counries}. Год: {Year}";
            return info;
        }
    }
}
