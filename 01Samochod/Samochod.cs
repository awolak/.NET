using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Samochod {
    class Samochod {
        private string model;
        private string marka;
        private Silnik silnik;
        private Punkt pozycja;

        public Samochod(string model, string marka, double pojemnosc, int pozycjaX, int pozycjaY) {
            this.model = model;
            this.marka = marka;
            silnik = new Silnik(pojemnosc);
            pozycja = new Punkt(pozycjaX, pozycjaY);
        }

        public Samochod(string model, string marka, Silnik silnik, Punkt punkt)
            : this(model, marka, silnik.PobierzPojemnosc(), punkt.PobierzX(), punkt.PobierzY()) {
        }

        public Samochod(string model, string marka, double pojemnosc)
            : this(model, marka, pojemnosc, 0, 0) {
        }

        public Samochod(string model, string marka)
            : this(model, marka, 76.2) {
        }
        public Samochod(string model)
            : this(model, "AMG GT-R") {
        }
        public Samochod()
            : this("Mercedes") {
        }

        public string PobierzInformacje() {
            return string.Format("SAMOCHOD:\n model:   {0}\n marka: {1}\n pojemnosc silnika: {2}\n znajduje się w punkcie: ({3}; {4})\n",
                model, marka, silnik.PobierzPojemnosc(), pozycja.PobierzX(), pozycja.PobierzY());
        }

        /*#region Zadanie 2
        public void ZmienKaliber(double nowyKaliber) {
            dzialo.ZmienKaliber(nowyKaliber);
        }
        public void ZmienPozycje(int x, int y) {
            pozycja.ZmienX(x);
            pozycja.ZmienY(y);
        }
        public void ZmienNazwe(string nowaNazwa) {
            nazwa = nowaNazwa;
        }
        public Samochod Klonuj() {
            return (Samochod)this.MemberwiseClone();
        }
        public Samochod(Samochod prototyp) {
            numerCzolgu = prototyp.numerCzolgu;
            nazwa = prototyp.nazwa;
            dzialo = new Silnik(prototyp.dzialo);
            pozycja = prototyp.pozycja;
        }
        #endregion*/

    }
}
