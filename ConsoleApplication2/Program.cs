using System;
using System.Collections.Generic;
using System.Linq;

namespace Poker
{
    class Gracze
    {
        public string Nazwa { get; set; }

        //Na wypadek gdyby nie dodano imienia bądź nicku
        public Gracze()
        {
            Nazwa = "Brak";
        }

        public Gracze(string nazwa)
        {
            Nazwa = nazwa;
        }

    }
    internal class Program
    {
        public static void SetReka(List<string> list)
        {
            string[] Wszystkie = {
                "2♠", "2♥", "2♦", "2♣",
                "3♠", "3♥", "3♦", "3♣",
                "4♠", "4♥", "4♦", "4♣",
                "5♠", "5♥", "5♦", "5♣",
                "6♠", "6♥", "6♦", "6♣",
                "7♠", "7♥", "7♦", "7♣",
                "8♠", "8♥", "8♦", "8♣",
                "9♠", "9♥", "9♦", "9♣",
                "10♠", "10♥", "10♦", "10♣",
                "J♠", "J♥", "J♦", "J♣",
                "Q♠", "Q♥", "Q♦", "Q♣",
                "K♠", "K♥", "K♦", "K♣",
                "A♠", "A♥", "A♦", "A♣"
            };

            Random r = new Random();
            for (int i = 0; i < 2; i++)
            {
                int element = r.Next(0, Wszystkie.Length);
                list.Add(Wszystkie[element]);
                Wszystkie[element] = "";
            }
        }

        public static void SetStol(List<string> list)
        {
            string[] Wszystkie = {
                "2♠", "2♥", "2♦", "2♣",
                "3♠", "3♥", "3♦", "3♣",
                "4♠", "4♥", "4♦", "4♣",
                "5♠", "5♥", "5♦", "5♣",
                "6♠", "6♥", "6♦", "6♣",
                "7♠", "7♥", "7♦", "7♣",
                "8♠", "8♥", "8♦", "8♣",
                "9♠", "9♥", "9♦", "9♣",
                "10♠", "10♥", "10♦", "10♣",
                "J♠", "J♥", "J♦", "J♣",
                "Q♠", "Q♥", "Q♦", "Q♣",
                "K♠", "K♥", "K♦", "K♣",
                "A♠", "A♥", "A♦", "A♣"
            };

            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                int element = r.Next(0, Wszystkie.Length);
                list.Add(Wszystkie[element]);
                Wszystkie[element] = "";
            }
        }

        public static void GetReka(List<string> list)
        {
            Console.WriteLine("Ręka Gracza : ");
            foreach (var element in list)
            {
                Console.Write(element + " ");
            }
        }
        public static void GetStol(List<string> list)
        {
            Console.WriteLine("Karty w Stole : ");
            foreach (var element in list)
            {
                Console.Write(element + " ");
            }
        }

        //Ta funkcja sie przyda do porownywania potem czy ktos ma np pare
        /*
         * Dlaczego?
         * Bo jak bedzie lista 7 elementowa i sobie posortuje to latwiej bedzie
         * sprawdzic czy jest para, trojka,kareta itd.
         */
        public static List<string> TworzenieWynikowej(List<string> a, List<string> b)
        {
            List<string> Wynikowa = new List<string>();
            for (int i = 0; i < a.Count; i++)
            {
                Wynikowa.Add(a[i]);
            }
            for (int i = 0; i < b.Count; i++)
            {
                Wynikowa.Add(b[i]);
            }

            return Wynikowa;
        }

        public static bool Pusto(List<string> list)
        {
            bool Pustak = false;
            list.Sort();
            int ilosc = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                string wartoscKarty1 = list[i].Substring(0, list[i].Length - 1);
                string kolorKarty1 = list[i].Substring(list[i].Length - 1, 1);
                string wartoscKarty2 = list[i + 1].Substring(0, list[i + 1].Length - 1);
                string kolorKarty2 = list[i + 1].Substring(list[i + 1].Length - 1, 1);

                if (wartoscKarty1 == wartoscKarty2 && kolorKarty1 != kolorKarty2)
                {
                    ilosc++;
                }
            }

            if (ilosc == 0)
            {
                Pustak = true;
            }

            return Pustak;
        }
        public static bool Kolor(List<string> list)
        {
            bool kolor = false;
            list.Sort();
            int ilosc = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                string wartoscKarty1 = list[i].Substring(0, list[i].Length - 1);
                string kolorKarty1 = list[i].Substring(list[i].Length - 1, 1);
                string wartoscKarty2 = list[i + 1].Substring(0, list[i + 1].Length - 1);
                string kolorKarty2 = list[i + 1].Substring(list[i + 1].Length - 1, 1);

                if (wartoscKarty1 != wartoscKarty2 && kolorKarty1 == kolorKarty2)
                {
                    ilosc++;
                }
            }

            if (ilosc == 4)
            {
                kolor = true;
            }

            return kolor;
        }

        public static bool Para(List<string> list)
        {
            bool czyPara = false;
            list.Sort();
            int ilosc = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                string wartoscKarty1 = list[i].Substring(0, list[i].Length - 1);
                string kolorKarty1 = list[i].Substring(list[i].Length - 1, 1);
                string wartoscKarty2 = list[i + 1].Substring(0, list[i + 1].Length - 1);
                string kolorKarty2 = list[i + 1].Substring(list[i + 1].Length - 1, 1);

                if (wartoscKarty1 == wartoscKarty2 && kolorKarty1 != kolorKarty2)
                {
                    ilosc++;
                }
            }

            if (ilosc >= 1)
            {
                czyPara = true;
            }

            return czyPara;
        }

        public static bool DwiePary(List<string> list)
        {
            bool czyDwiePary = false;
            list.Sort();
            int iloscPar = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                string wartoscKarty1 = list[i].Substring(0, list[i].Length - 1);
                string kolorKarty1 = list[i].Substring(list[i].Length - 1, 1);
                string wartoscKarty2 = list[i + 1].Substring(0, list[i + 1].Length - 1);
                string kolorKarty2 = list[i + 1].Substring(list[i + 1].Length - 1, 1);

                if (wartoscKarty1 == wartoscKarty2 && kolorKarty1 != kolorKarty2)
                {
                    iloscPar++;
                    i++;
                }
            }

            if (iloscPar >= 2)
            {
                czyDwiePary = true;
            }

            return czyDwiePary;
        }

        public static bool Strit(List<string> list)
        {
            bool czyStrit = false;
            list.Sort();
            int iloscKart = list.Count;
            for (int i = 0; i < iloscKart - 1; i++)
            {
                string wartoscKarty1 = list[i].Substring(0, list[i].Length - 1);
                string wartoscKarty2 = list[i + 1].Substring(0, list[i + 1].Length - 1);

                if (Int32.Parse(wartoscKarty1) + 1 == Int32.Parse(wartoscKarty2))
                {
                    czyStrit = true;
                }
                else
                {
                    czyStrit = false;
                    break;
                }
            }

            return czyStrit;
        }

        public static bool Trojka(List<string> list)
        {
            bool trojka = false;
            for (int i = 0; i < list.Count - 2; i++)
            {
                string wartoscKarty1 = list[i].Substring(0, list[i].Length - 1);
                string wartoscKarty2 = list[i + 1].Substring(0, list[i + 1].Length - 1);
                string wartoscKarty3 = list[i + 2].Substring(0, list[i + 2].Length - 1);

                if (wartoscKarty1 == wartoscKarty2 && wartoscKarty2 == wartoscKarty3)
                {
                    trojka = true;
                    break;
                }
            }

            return trojka;
        }

        public static bool Kareta(List<string> list)
        {
            bool czyKareta = false;
            list.Sort();
            int iloscKart = list.Count;
            for (int i = 0; i < iloscKart - 3; i++)
            {
                string wartoscKarty1 = list[i].Substring(0, list[i].Length - 1);
                string wartoscKarty2 = list[i + 1].Substring(0, list[i + 1].Length - 1);
                string wartoscKarty3 = list[i + 2].Substring(0, list[i + 2].Length - 1);
                string wartoscKarty4 = list[i + 3].Substring(0, list[i + 3].Length - 1);

                if (wartoscKarty1 == wartoscKarty2 && wartoscKarty2 == wartoscKarty3 && wartoscKarty3 == wartoscKarty4)
                {
                    czyKareta = true;
                    break;
                }
            }

            return czyKareta;
        }

        public static bool Full(List<string> list)
        {
            bool czyFull = false;
            list.Sort();
            int iloscKart = list.Count;
            bool trojka = false;
            bool para = false;

            for (int i = 0; i < iloscKart - 2; i++)
            {
                string wartoscKarty1 = list[i].Substring(0, list[i].Length - 1);
                string wartoscKarty2 = list[i + 1].Substring(0, list[i + 1].Length - 1);
                string wartoscKarty3 = list[i + 2].Substring(0, list[i + 2].Length - 1);

                if (wartoscKarty1 == wartoscKarty2 && wartoscKarty2 == wartoscKarty3)
                {
                    trojka = true;
                    break;
                }
            }

            for (int i = 0; i < iloscKart - 1; i++)
            {
                string wartoscKarty1 = list[i].Substring(0, list[i].Length - 1);
                string wartoscKarty2 = list[i + 1].Substring(0, list[i + 1].Length - 1);

                if (wartoscKarty1 == wartoscKarty2)
                {
                    para = true;
                    break;
                }
            }

            if (trojka && para)
            {
                czyFull = true;
            }

            return czyFull;
        }
        public static bool Poker(List<string> reka)
        {
            reka.Sort();
            if (reka[2].Substring(0, 2) != "10")
            {
                return false;
            }

            string kolorPierwszejKarty = reka[0].Substring(reka[0].Length - 1, 1);
            foreach (var karta in reka)
            {
                string kolorKarty = karta.Substring(karta.Length - 1, 1);
                if (kolorKarty != kolorPierwszejKarty)
                {
                    return false;
                }
            }

            for (int i = 0; i < reka.Count - 1; i++)
            {
                string wartoscKarty1 = reka[i].Substring(0, reka[i].Length - 1);
                string wartoscKarty2 = reka[i + 1].Substring(0, reka[i + 1].Length - 1);

                if (Int32.Parse(wartoscKarty1) + 1 != Int32.Parse(wartoscKarty2))
                {
                    return false;
                }
            }

            return true;
        }
        
        public static void Main(string[] args)
        {
            List<string> Reka = new List<string>();
            List<string> Stol = new List<string>();
            List<string> Wszystkie = new List<string>();
            int kasa = 500;
            int wartosc = 0; //Wartość na zasadzie sprawdzania kto ma lepszą rękę
            Console.WriteLine("Rozpoczynanie gry w Pokera!");
            Console.WriteLine("Zaczynamy z 500 $");
            Console.WriteLine("Podaj jak się nazywasz!");
            string nick = Console.ReadLine();
            SetReka(Reka);
            GetReka(Reka);
            Console.WriteLine("Ile inwestujemy?");
            bool poprawnaInwestycja = false;
            int inwestycja = 0;
            while (!poprawnaInwestycja)
            {
                try
                {
                    inwestycja = int.Parse(Console.ReadLine());
                    poprawnaInwestycja = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podaj poprawną liczbę!");
                }
            }
            if (inwestycja > kasa)
            {
                Console.WriteLine("Brak pieniędzy!");
            }
            else
            {
                kasa -= inwestycja;
            }
            Dictionary<Gracze, int> Wynik = new Dictionary<Gracze, int>();
            Gracze TY = new Gracze(nick);
            Wszystkie = TworzenieWynikowej(Reka, Stol);
            if (Pusto(Wszystkie) == true)
            {
                wartosc = 0;
            }

            else if (Para(Wszystkie) == true)
            {
                wartosc = 1;
            }
            else if (DwiePary(Wszystkie) == true)
            {
                wartosc = 2;
            }
            else if(Trojka(Wszystkie) == true)
            {
                wartosc = 3;
            }
            else if(Strit(Wszystkie) == true)
            {
                wartosc = 4;
            }
            else if (Kolor(Wszystkie) == true)
            {
                wartosc = 5;
            }
            else if (Full(Wszystkie) == true)
            {
                wartosc = 6;
            }
            else if(Kareta(Wszystkie) == true)
            {
                wartosc = 7;
            }
            else if (Poker(Wszystkie) == true)
            {
                wartosc = 8;
            }
            Wynik.Add(TY,wartosc);
            for (int i = 0; i < 3; i++)
            {
                Random r = new Random();
                Gracze gracz = new Gracze($"Gracz{i}");
                Wynik.Add(gracz,r.Next(0,9));
            }

            List<int> pomocnicza = new List<int>();
            foreach (var element in Wynik)
            {
                pomocnicza.Add(element.Value);
            }

            int ilosc_maxow = 1;
            int max = 0;
            max = pomocnicza.Max();
            for (int i = 0; i < pomocnicza.Count; i++)
            {
                if (max == pomocnicza[i])
                {
                    ilosc_maxow++;
                }
            }
            if(ilosc_maxow != 1)
            {
                Console.WriteLine("Kasa zwrócona remis!");
                kasa += inwestycja;
            }
            else
            {
                if (max == wartosc) // Sprawdzanie czy wygrałeś!
                {
                    Console.WriteLine($"Wygrałeś! Nowy stan konta : {kasa}");
                    kasa += inwestycja;
                }
                else
                {
                    Console.WriteLine($"Przegrałeś! Nowy stan konta : {kasa}");
                }
            }

            Console.WriteLine("Ręce pozostałych graczy!");
            foreach (var element in Wynik)
            {
                Console.Write($"{element.Key} {element.Value}");   
            }

            bool endGame = false;
            while (!endGame)
            {
                Console.WriteLine("Naciśnij ESC, aby wyjść lub dowolny inny klawisz, aby kontynuować.");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape || kasa <= 0)
                {
                    endGame = true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Kontynuujemy grę!");
                    Console.WriteLine($"Stan konta: {kasa}");
                    SetReka(Reka);
                    GetReka(Reka);
                    Console.WriteLine("Ile inwestujemy?");
                    poprawnaInwestycja = false;
                    while (!poprawnaInwestycja)
                    {
                        try
                        {
                            inwestycja = int.Parse(Console.ReadLine());
                            poprawnaInwestycja = true;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Podaj poprawną liczbę!");
                        }
                    }
                    if (inwestycja > kasa)
                    {
                        Console.WriteLine("Brak pieniędzy!");
                    }
                    else
                    {
                        kasa -= inwestycja;
                    }
                    Wszystkie = TworzenieWynikowej(Reka, Stol);
                    if (Pusto(Wszystkie) == true)
                    {
                        wartosc = 0;
                    }

                    else if (Para(Wszystkie) == true)
                    {
                        wartosc = 1;
                    }
                    else if (DwiePary(Wszystkie) == true)
                    {
                        wartosc = 2;
                    }
                    else if(Trojka(Wszystkie) == true)
                    {
                        wartosc = 3;
                    }
                    else if(Strit(Wszystkie) == true)
                    {
                        wartosc = 4;
                    }
                    else if (Kolor(Wszystkie) == true)
                    {
                        wartosc = 5;
                    }
                    else if (Full(Wszystkie) == true)
                    {
                        wartosc = 6;
                    }
                    else if(Kareta(Wszystkie) == true)
                    {
                        wartosc = 7;
                    }
                    else if (Poker(Wszystkie) == true)
                    {
                        wartosc = 8;
                    }
                    Wynik.Clear();
                    Wynik.Add(TY,wartosc);
                    for (int i = 0; i < 3; i++)
                    {
                        Random r = new Random();
                        Gracze gracz = new Gracze($"Gracz{i}");
                        Wynik.Add(gracz,r.Next(0,9));
                    }

                    pomocnicza.Clear();
                    foreach (var element in Wynik)
                    {
                        pomocnicza.Add(element.Value);
                    }

                    ilosc_maxow = 1;
                    max = 0;
                    max = pomocnicza.Max();
                    for (int i = 0; i < pomocnicza.Count; i++)
                    {
                        if (max == pomocnicza[i])
                        {
                            ilosc_maxow++;
                        }
                    }
                    if(ilosc_maxow != 1)
                    {
                        Console.WriteLine("Kasa zwrócona remis!");
                        kasa += inwestycja;
                    }
                    else
                    {
                        if (max == wartosc) // Sprawdzanie czy wygrałeś!
                        {
                            Console.WriteLine($"Wygrałeś! Nowy stan konta : {kasa}");
                            kasa += inwestycja;
                        }
                        else
                        {
                            Console.WriteLine($"Przegrałeś! Nowy stan konta : {kasa}");
                        }
                    }

                    Console.WriteLine("Ręce pozostałych graczy!");
                    foreach (var element in Wynik)
                    {
                        Console.Write($"{element.Key.Nazwa} {element.Value}");   
                    }
                }
            }
        }
    }
}
