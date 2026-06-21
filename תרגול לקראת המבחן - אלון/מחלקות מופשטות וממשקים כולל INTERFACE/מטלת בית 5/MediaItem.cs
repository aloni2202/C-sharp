using System;
using System.Collections.Generic;
using System.Text;

namespace מטלת_בית_5
{
    abstract class MediaItem
    {
        public string Title { get; set; }

        public int Durarion { get; set; }

        protected MediaItem(string title , int duration)
        {
            Title = title;
            Durarion = duration;
            
        }

        public abstract void Play();
    }
   
}
