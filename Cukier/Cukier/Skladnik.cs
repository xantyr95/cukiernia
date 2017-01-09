using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cukier
{
    class Skladnik : IComparable<Skladnik>
    {
        private string nazwaSkladnika;
        private string Ilosc;
        private double CenaSkladnika;
        public Skladnik() { }
        public Skladnik(string nazwaSkladnika, string Ilosc, double CenaSkladnika)
        {
            this.nazwaSkladnika = nazwaSkladnika;
            this.Ilosc = Ilosc;
            this.CenaSkladnika = CenaSkladnika;
        }
        public override string ToString()
        {
            return "Nazwa skladnika: " + nazwaSkladnika + "ilosc: " + Ilosc + "cena skladnika: " + CenaSkladnika.ToString();
        }
        public double zwracamCene()
        {
            return CenaSkladnika;
        }
        public int CompareTo(Skladnik other)
        {
            return this.nazwaSkladnika.CompareTo(other.nazwaSkladnika);
        }

    }
}