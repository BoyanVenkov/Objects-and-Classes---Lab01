class Program
{
    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 1; i <= n; i++)
        {
            string[] input = Console.ReadLine().Split("_").ToArray();

            string typeList = input[0];
            string name = input[1];
            string time = input[2];
            Song currentSong = new Song(typeList, name, time);
            songs.Add(currentSong);
        }
        string lastCommand = Console.ReadLine();
        if (lastCommand == "all")
        {
            foreach (var song in songs)
            {
                Console.WriteLine($"{song.Name}");
            }
        }
        else
        {
            foreach (var song in songs.Where(song => song.TypeList == lastCommand))
            {
                Console.WriteLine($"{song.Name}");
            }
        
        }

    }


}