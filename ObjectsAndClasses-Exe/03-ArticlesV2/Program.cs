using System.Reflection;

namespace _03_ArticlesV2
{
    internal class Program
    {
        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }


            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < count; i++)
            {
                string[] action = Console.ReadLine().Split(", ");

                Article article = new Article(action[0], action[1], action[2]);

                articles.Add(article);
            }

            Console.WriteLine(string.Join("\n", articles));
        }
    }
}
