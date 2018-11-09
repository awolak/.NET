using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Samochod {
    class Silnik {
        private double pojemnosc;
        public Silnik(double pojemnosc) {
            this.pojemnosc = pojemnosc;
        }

        public double PobierzPojemnosc() {
            return pojemnosc;
        }
        /*#region Zadanie 2
        public void ZmienKaliber(double nowyKaliber) {
            kaliber = nowyKaliber;
        }

        public Silnik(Silnik prototyp) {
            kaliber = prototyp.kaliber;
        }
        #endregion*/
    }
}
