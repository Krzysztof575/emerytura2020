using System;

namespace ConsoleApp
{
    class Program
    {
        const int WiekEmerytalny = 70;

        
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj!");
            Console.Write("Podaj imię: ");
            string imie; // deklaracja zmiennej
            imie = Console.ReadLine(); // przypisanie

            Console.Write("Podaj nazwisko: "); // cw Tab Tab - Code Snippet
            string nazwisko = Console.ReadLine().ToUpper(); // deklaracja z inicjalizacją
            // nazwisko = nazwisko.ToUpper();

            Console.WriteLine("Witaj " + imie + " " + nazwisko); // konkatenacja napisów za pomocą plusa +
            Console.WriteLine("Witaj {0} {1}!", imie, nazwisko); // formatowany string
            Console.WriteLine($"Witaj {imie} {nazwisko}!!"); // string interpolowany
            
            Console.WriteLine("Podaj swój wiek: ");
            string linia = Console.ReadLine();
            int wiek = int.Parse(linia); // parsowanie napisu do liczy całkowitej
            //int wiek = Convert.ToInt32(linia); //równoważny sposób
            if( wiek > WiekEmerytalny )
            {
                Console.WriteLine("Jesteś emerytem");
            }
            else
            {
                Console.WriteLine($"Do emerytury zostało Ci  lat {WiekEmerytalny - wiek}");
            }

        }
    }
}
