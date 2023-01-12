using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    class Pekar : Zamestnanec
    {
        int hodinyvnoci = 0;
        public Pekar(string jmeno, DateTime datumnarozeni, int mzdazahodinu, int hodinyvnoci) : base(jmeno, datumnarozeni, mzdazahodinu)
        {
            this.hodinyvnoci = hodinyvnoci;
        }
        public void OdpracujHodiny(int hodiny, int hodinyvnoci)
        {
            odpracovanehodiny += hodiny;
            odpracovanehodiny += hodinyvnoci * 2;
        }
        public override int Mzda(int mzdazahodinu, int odpracovanehodiny)
        {
            return base.Mzda(mzdazahodinu, odpracovanehodiny);
        }
    }
}
