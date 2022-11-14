using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyümölcs
{
    internal class gyumolcs
    {
        int id;
        string nev;
        string egysegar;
        double menniseg;

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Egysegar { get => egysegar; set => egysegar = value; }
        public double Menniseg { get => menniseg; set => menniseg = value; }

        public gyumolcs(int id, string nev, string egysegar, double menniseg)
        {
            Id = id;
            Nev = nev;
            Egysegar = egysegar;
            Menniseg = menniseg;
        }
        public override string ToString()
        {
            return nev + " (" + Egysegar + "Ft/kg) " + Menniseg + "db vett.";
        }
    }
}
