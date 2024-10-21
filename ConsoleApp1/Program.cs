using System;

namespace HotelBook
{
    class Program
    {
        static void Main(string[] args)
        {
            //zadanie 1
            /*Namespace: pozwala na organizacje kodu, dzięki temu można grupować pokrewne klasy, unika się dzięki temu konfliktu w przypadku używania tych samych nazw dla metod.
            Class: to blok z którego tworzymy kod, w nim piszemy strukturę i zachowanie obiektów, definiujemy jego właściwości i metody 
            Main: jest to wejście do programu, i rozpoczęcie wykonywania, 
            using: służy do deklarowania przestrzeni nazw, można dzięki temu skrócić pisanie pełnych nazw metod
            */

            //Zadanie 2
            Console.Write("Hello World");
            Console.Write(" to jest mój pierwszy program");

            //Zadanie 4
            Console.WriteLine("");
            Console.Write("Hello World");
            Console.Write(" ");
            Console.Write("\n");
            Console.Write("\t");


            //Zadanie 5
            Console.WriteLine("tekst" == "tekst");
            Console.WriteLine("K" == "k");
            Console.WriteLine(1 == 4);
            string myValue = "K";
            Console.WriteLine(myValue == "K");

            //Sprawdź działanie programu
            Console.WriteLine(1 > 5);
            Console.WriteLine(1 < 5);
            Console.WriteLine(1 >= 5);
            Console.WriteLine(1 <= 5);

            //Zadanie 6
            string test = "Moj pierwszy program";
            Console.WriteLine(test.Substring(4, 2));
            //Substring zaczyna na 4 literze podanego stringa i zwraca dwie kolejne


            //zadanie 7
            int mojWiek = 50;
            int twojWiek = mojWiek > 40 ? 40 : 20;
            Console.WriteLine($"Twój Wiek: {twojWiek}");

            /*
             int mojWiek = 50;
             int twojWiek = mojWiek < 40 ? 40 : 20;
             Console.WriteLine($"Twój Wiek: {twojWiek}");
             
            */

            //Zadanie 8

            double[] liczby = { 0, 4, 256, 1024, 10, 100, 1, 50, 20, 64 };
            //a)[8]: 0,4,400,2000,12,144,1,62,24,100
            //b)[16]: 0,4,100,400, A, 64, 1, 32, E, 40
            //c)[2]: 0,100,100000000,10000000000,1010,1100100,1,110010,10100,1000000


            int system = 8;

            foreach (double l in liczby)
            {
                double liczba = l;
                string wynik = "";

                if (liczba == 0)
                {
                    wynik = "0";
                }
                else
                {
                    while (liczba > 0)
                    {
                        double remainder = liczba % system;
                        wynik = remainder.ToString() + wynik;
                        liczba = Math.Floor(liczba / system);
                    }
                }

                Console.WriteLine($"Liczba: {l} w systemie {system} to: {wynik}");
            }

            //Zadanie 9
            double Tmp;
            //double $tmp; znaki zmienne w zmienntch nie są dozwolone
            //float tmp’; znaki zmienne w zmienntch nie są dozwolone
            //string 3tm; liczby na początku zmiennej nie są dozwolone
            char _tmp;
            int mojNumer = 5;
            int _mojNumer = 5;
            //int 5mojNumer = 5; liczby na początku zmiennej nie są dozwolone
            //int moj Numer = 5; spacje w nazwie zmiennych nie są dozwolone
            //int %mojNumer = 5; znaki zmienne w zmienntch nie są dozwolone
            int MojNumer = 5;


            //Zadanie 10
            int testvar = 8;
            int Testvar = 8;
            //zmienne te moga istnieć

            //Zadanie 11
            DateTime dzisiejszaData = DateTime.Now;
            Console.WriteLine("Dzisiejsza data: " + dzisiejszaData);

            //Zadanie 12

            Console.Write("Podaj rok urodzenia: ");
            int rokUrodzenia = int.Parse(Console.ReadLine());
            Console.Write("Wpisz i nazwisko: ");
            string imieINazwisko = Console.ReadLine();
            Console.Write("Podaj swój wiek: ");
            int wiek = int.Parse(Console.ReadLine());
            Console.Write("Podaj miejsce urodzenia: ");
            string mscUrodzenia = Console.ReadLine();

            Console.WriteLine($"{rokUrodzenia},\t{imieINazwisko},\t{wiek}\t{mscUrodzenia}");


            //Zadanie 13
            int rozmiar;

            rozmiar = sizeof(float);
            Console.WriteLine($"Rozmiar typu float: {rozmiar} bajtów");

            rozmiar = sizeof(char);
            Console.WriteLine($"Rozmiar typu char: {rozmiar} bajtów");

            rozmiar = sizeof(double);
            Console.WriteLine($"Rozmiar typu double: {rozmiar} bajtów");

            rozmiar = sizeof(int);
            Console.WriteLine($"Rozmiar typu int: {rozmiar} bajtów");


            //Zadanie 14

            int wiek2 = 0;
            while (wiek2 % 2 == 0)
            {
                Console.Write("Wpisz liczbę nieparzystą: ");
                wiek2 = int.Parse(Console.ReadLine());
            }


            int wiek3 = wiek2;
            double wiek4 = wiek2;
            float wiek5 = wiek2;

            //Zadanie 15

            Console.Write("Wpisz liczbę binarną: ");
            Int32 decNum = Convert.ToInt32(Console.ReadLine(), 2);

            Console.WriteLine($"Twoja liczba to: {decNum}");
        }
    }
}