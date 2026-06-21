using System;
using System.Collections.Generic;
using System.Text;

namespace מטלת_בית_5
{
    internal class Song : MediaItem, IDownloadable
    {
        public Song(string title, int duration) : base(title, duration)
        {
        }

        public void Download()
        {
            Console.WriteLine("Downloading song File");
        }

        public override void Play()
        {
            Console.WriteLine("Playing song");
        }
    }
}
