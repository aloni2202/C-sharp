namespace Task5__מערכת_ניהול_ספריית_מדיה
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaItem[] items = {
                new Song{Title = "eye in the sky" , Duration = 3},
                new Movie{Title = "Fauda" , Duration = 50},
                new LiveStream{Title = "12 news" , Duration = 120} };

            Console.WriteLine("Playing all media item : ");

            foreach (var item in items)
            {
                item.Play();
            }

            Movie[] movies = {
                new Movie{Title = "The Fast and the Furious" , Duration = 88},
                new Movie{Title = "The Godfather" , Duration = 100},
                new Movie{Title = "Toy Story" , Duration = 78}, };

            Array.Sort(movies);
            foreach (var item in movies)
            {
                Console.WriteLine($"{item.Title} is {item.Duration} min ");
            }
        }
    }
}
