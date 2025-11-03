namespace _01_AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                AdvertismentMessage message = new AdvertismentMessage();

                Console.WriteLine(message.GetMessage());
            }
        }

        public class AdvertismentMessage
        {
            private readonly string[] phrases =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };

            private readonly string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };

            private readonly string[] authors =
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };

            private readonly string[] cities =
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            public string GetMessage()
            {
                Random randomMessage = new Random();

                int phrasesIndex = randomMessage.Next(phrases.Length);
                string phrase = phrases[phrasesIndex];

                int eventsIndex = randomMessage.Next(events.Length);
                string @event = events[eventsIndex];

                int authorIndex = randomMessage.Next(authors.Length);
                string author = authors[authorIndex];

                int citiesIndex = randomMessage.Next(cities.Length);
                string city = cities[citiesIndex];

                return $"{phrase} {@event} {author} – {city}.";
            }
        }

    }
}
