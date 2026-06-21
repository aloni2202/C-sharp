using System;
using System.Collections.Generic;
using System.Text;

namespace מטלת_בית_5
{
    internal class Movie : MediaItem, IDownloadable , IComparable<Movie>
    {
        public Movie(string title, int duration) : base(title, duration)
        {

        }

        public override void Play()
        {
            Console.WriteLine("Playing movie");
        }

        public void Download()
        {
            Console.WriteLine("Downloading movie file");
        }

        public int CompareTo(Movie other)
        {
            if (other == null)
            {
                return 1;
            }
            return Durarion.CompareTo(other.Durarion);
        }
    }
}
