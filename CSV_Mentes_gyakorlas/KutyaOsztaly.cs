using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Mentes_gyakorlas
{
    class KutyaOsztaly
    {
        string nev;
        string nem;
        DateTime szuletesNap;

        public KutyaOsztaly(string nev, string nem, DateTime szuletesNap)
        {
            string Nev = nev;
            string Nem = nem;
            DateTime SzuletesNap = szuletesNap;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Nem { get => nem; set => nem = value; }
        public DateTime SzuletesNap { get => szuletesNap; set => szuletesNap = value; }

        public override string ToString()
        {
            return nev + nem + szuletesNap;
        }
    }
}
