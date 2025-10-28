using System.Collections.Generic;

namespace _06_CardsGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> secondPlayerDeck = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (firstPlayerDeck.Count >= 0 && secondPlayerDeck.Count >= 0)
            {
                int firstPlayer = firstPlayerDeck[0];
                int secondPlayer = secondPlayerDeck[0];

                if (firstPlayer > secondPlayer)
                {
                    firstPlayerDeck.Add(firstPlayer);
                    firstPlayerDeck.Add(secondPlayer);
                }
                else if (secondPlayer > firstPlayer)
                {
                    secondPlayerDeck.Add(secondPlayer);
                    secondPlayerDeck.Add(firstPlayer);
                }

                firstPlayerDeck.Remove(firstPlayer);
                secondPlayerDeck.Remove(secondPlayer);

                if (firstPlayerDeck.Count == 0)
                {
                    int secondPlayerWinn = secondPlayerDeck.Sum();
                    Console.WriteLine($"Second player wins! Sum: {secondPlayerWinn}");
                    return;

                }
                else if (secondPlayerDeck.Count == 0)
                {
                    int firstPlayerWinn = firstPlayerDeck.Sum();
                    Console.WriteLine($"First player wins! Sum: {firstPlayerWinn}");
                    return;
                }
            }
        }
    }
}
