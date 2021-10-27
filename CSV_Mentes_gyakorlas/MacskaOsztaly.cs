using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Mentes_gyakorlas
{
    class MacskaOsztaly
    {
        string nev;
        string nem;
        DateTime szuletesNap;

        public MacskaOsztaly(string nev, string nem, DateTime szuletesNap)
        {
            Nev = nev;
            Nem = nem;
            this.SzuletesNap = szuletesNap;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Nem { get => nem; set => nem = value; }
        public DateTime SzuletesNap
        {
            get => szuletesNap;
            set
            {
                if (DateTime.Compare(DateTime.Now, value) == 1)
                {
                    szuletesNap = value;
                }
                else
                {
                    throw new Exception("Nem jó a dátum!");
                }
            }
        }
                 

        public override string ToString()
        {
            return nev + nem + szuletesNap;
        }

    }
}
