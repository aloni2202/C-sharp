using System;
using System.Collections.Generic;
using System.Text;

namespace מטלת_בית_5
{
    internal class LiveStream : MediaItem
    {
        public LiveStream(string title, int duration) : base(title, duration)
        {
        }

        public override void Play()
        {
            Console.WriteLine("Playing Live Strem");
        }
    }
}
