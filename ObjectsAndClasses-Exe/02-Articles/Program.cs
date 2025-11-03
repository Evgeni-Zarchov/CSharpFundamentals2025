namespace _02_Articles
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

            public void Edit(string content)
            {
                Content = content;
            }

            public void ChangeAuthor(string author)
            {
                Author = author;
            }

            public void Rename(string title)
            {
                Title = title;
            }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }


        static void Main(string[] args)
        {
            string[] info = Console.ReadLine().Split(", ");

            Article article = new Article(info[0], info[1], info[2]);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] action = Console.ReadLine().Split(": ");

                switch (action[0])
                {
                    case "Edit":
                        string content = action[1];
                        article.Edit(content);
                        break;
                    case "ChangeAuthor":
                        string author = action[1];
                        article.ChangeAuthor(author);
                        break;
                    case "Rename":
                        string title = action[1];
                        article.Rename(title);
                        break;
                }

            }

            Console.WriteLine(article.ToString());
        }

    }
}
