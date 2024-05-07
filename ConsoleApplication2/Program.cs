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

        public static void GetReka(List<string> list)
        {
            Console.WriteLine("Ręka Gracza : ");
            foreach (var element in list)
            {
                Console.Write(element + " ");   
            }
        }
        
        public static void Main(string[] args)
        {
            
        }
    }
}