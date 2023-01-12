using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp19
{
    class Zamestnanec
    {
        protected string jmeno;
        protected DateTime datumnarozeni;
        protected int mzdazahodinu;
        protected int odpracovanehodiny = 0;
        public Zamestnanec(string jmeno, DateTime datumnarozeni, int mzdazahodinu)
        {
            this.jmeno = jmeno;
            this.datumnarozeni = datumnarozeni;
            this.mzdazahodinu = mzdazahodinu;
        }
        public int Vek(DateTime datumnarozeni)
        {
            return (int)((DateTime.Now - datumnarozeni).TotalDays / 365.25);
        }
        public virtual int Mzda(int mzdazahodinu, int odpracovanehodiny)
        {
            return mzdazahodinu * odpracovanehodiny;
        }
        public string Vypis()
        {
            return "Jméno: " + jmeno + "\nDatum narození: " + datumnarozeni + "\nVěk: " + Vek(datumnarozeni) + "\nMzda za hodinu: " + mzdazahodinu + "\nOdpracované hodiny: " + odpracovanehodiny + "\nMzda: " + Mzda(mzdazahodinu, odpracovanehodiny);
        }
        public void OdpracujHodiny(int hodiny)
        {
            odpracovanehodiny += hodiny;
        }
    }
}
