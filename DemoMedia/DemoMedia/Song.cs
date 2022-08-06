using System;
using Windows.Storage;

namespace DemoMedia
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public TimeSpan Duration { get; set; }
        public StorageFile SongFile { get; set; }
    }
}