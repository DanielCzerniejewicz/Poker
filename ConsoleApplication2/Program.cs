using System;
using System.Collections.Generic;

namespace Poker
{
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
            for (int i = 0; i < a.Count; i++)
            {
                Wynikowa.Add(a[i]);
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

        public bool Trojka(List<string> list)
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

        public static void Main(string[] args)
        {
            List<string> Reka = new List<string>();
            List<string> Stol = new List<string>();
            List<string> Wszystkie = new List<string>();
            Wszystkie = TworzenieWynikowej(Reka, Stol);
        }
    }
}
