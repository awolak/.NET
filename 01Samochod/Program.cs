using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Samochod {
    class Program {
        static void Main(string[] args) {
            Punkt p1 = new Punkt(); //wszystko OK - struktura
            //Dzialo dz = new Dzialo(); //Blad - dla klas nie jest definiowany konstruktor domyslny gdy istnieje inny konstruktor
            Silnik s1 = new Silnik(78);

            Samochod samochod1 = new Samochod("Mercedes", "A-1", s1, p1);
            Samochod samochod2 = new Samochod();
            Samochod samochod3 = new Samochod("Fiat", "B-2", 83.5, 10, 34);
            Console.WriteLine(samochod1.PobierzInformacje());
            Console.WriteLine(samochod2.PobierzInformacje());
            Console.WriteLine(samochod3.PobierzInformacje());

           /*( #region Zadanie 2
            Console.WriteLine("\nKopiowanie płytkie.");
            Samochod oryginal1 = new Samochod(200, "Oryginal 1", 100, 10, 10);
            Samochod klon1 = oryginal1.Klonuj();
            Console.WriteLine("Oryginał: {0}", oryginal1.PobierzInformacje());
            Console.WriteLine("Klon:     {0}", klon1.PobierzInformacje());
            Console.WriteLine("Zmieniamy klona: ");
            klon1.ZmienKaliber(300);
            klon1.ZmienNazwe("Klon 1: ");
            klon1.ZmienPozycje(55, 55);
            Console.WriteLine("Oryginał: {0}", oryginal1.PobierzInformacje());
            Console.WriteLine("Klon:     {0}", klon1.PobierzInformacje());

            Console.WriteLine("\nKopiowanie głębokie.");
            Samochod oryginal2 = new Samochod(200, "Oryginal 2", 100, 10, 10);
            Samochod klon2 = new Samochod(oryginal2);
            Console.WriteLine("Oryginał: {0}", oryginal2.PobierzInformacje());
            Console.WriteLine("Klon:     {0}", klon2.PobierzInformacje());
            Console.WriteLine("Zmieniamy klona: ");
            klon2.ZmienKaliber(300);
            klon2.ZmienNazwe("Klon 2");
            klon2.ZmienPozycje(55, 55);
            Console.WriteLine("Oryginał: {0}", oryginal2.PobierzInformacje());
            Console.WriteLine("Klon:     {0}", klon2.PobierzInformacje());

            #endregion*/
            Console.ReadKey();
        }
    }
}
