using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy: ");
            string leng = Console.ReadLine();
            int size = 0;
            try
            {
                size = Convert.ToInt32(leng);
            }
            catch
            {
                Console.WriteLine("Podaj ponownie rozmiar tablicy: ");
                leng = Console.ReadLine();
                size = Convert.ToInt32(leng);
            }
            Console.WriteLine("Uzupełnij tablicę liczbami: (wciśnij ENTER po każdej wprowadzonej liczbie)");
            int[] tablica = new int[size];
            for (int i=0; i<size; i++)
            {
                string date = Console.ReadLine();
                int dane = 0;
                try
                {
                    dane = Convert.ToInt32(date);
                }
                catch
                {
                    Console.WriteLine("To nie jest liczba, wprowadź ponownie: ");
                    date = Console.ReadLine();
                    dane = Convert.ToInt32(date);
                }
                tablica[i] = dane;
                if (i == size -1)
                {
                    Console.WriteLine("PEŁNA");
                    Console.WriteLine("Oto liczby które wprowadziłeś: ");
                    for(int x = 0; x < size; x++)
                    {
                        Console.Write(tablica[x] +", ");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
