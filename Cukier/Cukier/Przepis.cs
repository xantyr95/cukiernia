using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cukier
{
    class Przepis
    {
        private string Nazwa;
        private double Suma = 0;
        private List<Skladnik> Skladniki;
        private int czasPrzygotowania;
        public Przepis()
        {
            Skladniki = new List<Skladnik>();
        }
        public void DodajSkladnik(string nazwaSkladnika, string Ilosc, double cenaSkladnika)
        {
            Skladniki.Add(new Skladnik(nazwaSkladnika, Ilosc, cenaSkladnika));
            Suma += cenaSkladnika;
        }
        public void UstawNazweICzas(string Nazwa, int Czas)
        {
            this.Nazwa = Nazwa;
            this.czasPrzygotowania = Czas;
        }
        public override string ToString()
        {
            var Lista = (List<Skladnik>)Skladniki;
            if (Skladniki.Count > 0)
            {
                return "Przepis:\n" + "Nazwa: ";
            }
            else
            {
                return "";
            }
        }
        public bool CzyCzas()
        {
            if (czasPrzygotowania > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public int ileSkladnikow()
        {
            return Skladniki.Count;
        }
    }
}