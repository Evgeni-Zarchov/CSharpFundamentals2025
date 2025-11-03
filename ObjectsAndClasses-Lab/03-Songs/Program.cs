namespace _03_Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int songsCount = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < songsCount; i++)
            {
                string[] elements = Console.ReadLine().Split("_");

                string typeList = elements[0];
                string name = elements[1];
                string time = elements[2];

                Song song = new Song();

                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string type = Console.ReadLine();

            if (type == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (song.TypeList == "type")
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

            List<Song> filterSongs = songs
                .Where(s => s.TypeList == type)
                .ToList();

            foreach (Song song in filterSongs)
            {
                Console.WriteLine(song.Name);
            }
        }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
