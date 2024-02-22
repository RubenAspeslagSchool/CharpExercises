using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ
{
    internal class Exercise1BasicQueries
    {


        List<int> prices = new List<int> { 20, 35, 17, 105, 90 };
        List<string> games = new List<string> { "Dominion", "Manillen", "Chess", "Settlers of Catan", "Cluedo"};



        internal void Run()
        {
            //1. the prices divisible by 5
            //2. the biggest number
            //3. the second last number
            //4. The amount of characters of all games, without spaces
            //5. A sentence for each game: name of the game price € price from the first list on the same position
            Console.WriteLine("------------------exercise 01");

            Console.WriteLine("1- the prices divisible by 5");
            PricesDivisibleBy5().ForEach(x => Console.WriteLine(x));

            Console.WriteLine($"2- the biggest number: {BiggestNumber()} ");
            Console.WriteLine($"3- the second last number: {SecondLastNumber()} ");
            Console.WriteLine($"4- Total number of characters in all game names, excluding spaces: {AmountOfCharactersOfAllGamesWithoutSpaces()} ");

            Console.WriteLine("5- A sentence for each game: name of the game price € price from the first list on the same position");
            SentenceForEachGame().ForEach(x => Console.WriteLine(x));
        }
        public List<int> PricesDivisibleBy5()
        {
            return prices.Where(price => price%5 == 0).ToList();
        }

        public int BiggestNumber()
        {
           return prices
                .OrderDescending()
                .First();
        }

        public int SecondLastNumber() 
        {
            return prices.Skip(prices.Count - 2).First();
        }

        public int AmountOfCharactersOfAllGamesWithoutSpaces()
        {
            return games.Sum(game => game.Replace(" ", "").Length);
        }

        public List<string> SentenceForEachGame()
        {
            return games
                .Zip(prices, (game, price) => $"{game} price ${price}")
                .ToList();
        }

       


    }
}
