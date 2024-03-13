namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int songNumber = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for(int i = 0; i < songNumber; i++)
            {
                string[] intput = Console.ReadLine().Split("_");

                string type = intput[0];
                string name = intput[1];
                string time = intput[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }
            
            string typeList = Console.ReadLine();
            
            if(typeList == "all")
            {
                foreach(Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach(Song song in songs)
                {
                    if(song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
            /*List<Song> filteredSongs = songs
                .Where(s => s.TypeList == typeList)
                .ToList();

            foreach (Song song in filteredSongs)
            {
                Console.WriteLine(song.Name);
            }*/
        }
    }

    class Song
    { 
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

}