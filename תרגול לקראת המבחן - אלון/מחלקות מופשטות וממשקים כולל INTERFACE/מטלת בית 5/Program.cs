namespace מטלת_בית_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaItem m1 = new Movie("Caes", 120);
            MediaItem m2 = new Song("Hotel California", 4);
            MediaItem m3 = new LiveStream("Hadashot", 100);
            MediaItem[] media = new MediaItem[3] { m1, m2, m3 };

            for (int i = 0; i < media.Length; i++)
            {
                media[i].Play();
                Console.WriteLine();
            }

            Movie[] movies = new Movie[3];
            {
                movies[0] = new Movie("The Lion King", 88);
                movies[1] = new Movie("Inception", 148);
                movies[2] = new Movie("Interstellar", 169);
            }

            Array.Sort(movies);
            Console.WriteLine("Movies from short to the longest :");
            Console.WriteLine("-----------------------------------------------");
            foreach (Movie movie in movies)
            {
                Console.WriteLine($"{movie.Title} is {movie.Durarion} min");
                Console.WriteLine();
            }
}
}
}
