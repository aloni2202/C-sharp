using System;
using System.Collections.Generic;
using System.Text;

namespace Task5__מערכת_ניהול_ספריית_מדיה
{
    abstract class MediaItem
    {

        public string Title { get; set; }

        public int Duration { get; set; }

        public abstract void Play();

    }

    internal class Movie : MediaItem, IDownloadable, IComparable<Movie>
    {
        public void Download()
        {
            Console.WriteLine("Downloading movie file");
        }
        public override void Play()
        {
            Console.WriteLine("Playing movie");
        }
        public int CompareTo(Movie other)
        {
            if (other == null) 
            {
                return 1;
            }
            return this.Duration.CompareTo(other.Duration);
        }
    }
        internal class Song : MediaItem, IDownloadable
        {
            public void Download()
            {
                Console.WriteLine("Downloading song file");
            }
            public override void Play()
            {
                Console.WriteLine("Playing the song");
            }
        }
        internal class LiveStream : MediaItem
        {
            public override void Play()
            {
                Console.WriteLine("Starting live stream");
            }
        }
    }
