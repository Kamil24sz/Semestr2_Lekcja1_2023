using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semestr2_Lekcja1_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witam, to jest mój program konsolowy - Kamil");

            string ulubionaPotrawa = "Spaghetti";
            int wiek = 23;
            decimal kieszonkowe = 25.5M;
            char rozmiar = 'M';
            bool czyEkstraRomiar = false;

            Console.WriteLine("Mam " + wiek + " lat i lubię " + ulubionaPotrawa);
            Console.WriteLine($"Mam {wiek} lat i lubię {ulubionaPotrawa}");
            Console.WriteLine("Mam {0} lat i lubię {1}", wiek, ulubionaPotrawa);

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"{i}. Jestem głodny");
            }

            Console.WriteLine("Podaj ile kosztuje Twoja ulubiona potrawa");
            decimal cena = decimal.Parse(Console.ReadLine());
            Console.WriteLine($"Cena: {cena}");

            if (kieszonkowe >= cena)
            {
                Console.WriteLine($"Możesz kupić {(int)(kieszonkowe / cena)} porcji {ulubionaPotrawa}");
            }
            else
            {
                Console.WriteLine("Brak");
            }

            Console.WriteLine(ZamienRozmiar('+'));

            Console.WriteLine(ZamienRozmiarExtra('+', true));

            Console.ReadLine();
        }
        public static string ZamienRozmiar(char rozmiar)
        {

            switch (rozmiar)
            {
                case 'S':
                    return "Small";
                    break;

                case 'M':
                    return "Medium";
                    break;

                case 'L':
                    return "Large";
                    break;

                default:
                    return "Nieprawidłowy rozmiar";
                    break;
            }
        }
        public static string ZamienRozmiarExtra(char rozmiar, bool czyExtraRozmiar)
        {
            if(rozmiar == 'M')
            {
                return "Medium";
            }

            if (czyExtraRozmiar)
            {
                if (rozmiar == 'S')
                    return "Extra Small";

                if (rozmiar == 'L')
                    return "Extra Large";
            }
            else
            {
                if (rozmiar == 'S')
                    return "Small";

                if (rozmiar == 'L')
                    return "Large";
            }

            return "Nieprawidłowy rozmiar";
        }
    }
}
