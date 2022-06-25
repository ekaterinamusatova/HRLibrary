using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public class Show
    {
        public string Name;
        public string Host;
        public string Discribing;
        public Periodicity Period;
        public DateTime Time;

        public Show(string n, string h, string d)
        {
            Name = n;
            Host = h;
            Discribing = d;
        }
        public override string ToString()
        {
            return Name;
        }
        public virtual string[] GetInfo()
        {
            var info = new string[3];
            var day = new Dictionary<DayOfWeek, string>() 
            {
                { DayOfWeek.Sunday, "воскресеньям"},
                { DayOfWeek.Monday, "понедельникам"},
                { DayOfWeek.Tuesday, "вторникам"},
                { DayOfWeek.Wednesday, "средам"},
                { DayOfWeek.Thursday, "четвергам"},
                { DayOfWeek.Friday, "пятницам"},
                { DayOfWeek.Saturday, "субботам"}
            };
            info[0] = ToString() + $" (Ведущий: {Host})";
            info[1] = this.Discribing;
            if (this.Period == Periodicity.Daily)
                info[2] = $"Ежедневно в {Time:t}";
            else if (this.Period == Periodicity.Weekly)
                info[2] = $"По {day[Time.DayOfWeek]} в {Time:t}";
            else if (this.Period == Periodicity.Monhtly)
                info[2] = $"{Time.Day}-го числа каждого месяца в {Time:t}";
            else info[2] = $"{Time:M} в {Time:t}";
            return info;
        }
    }
}
