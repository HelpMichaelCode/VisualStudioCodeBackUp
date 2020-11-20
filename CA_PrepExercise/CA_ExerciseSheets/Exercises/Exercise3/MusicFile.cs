using System;
namespace Exercise3
{
    public class MusicFile : MediaFile
    {
        public string Title { get; }
        public string Artist { get; }
        public string Genre { get; }

        public MusicFile(string title, string artist, string genre, string fileName) : base(fileName)
        {
            if(Title != String.Empty && Artist != String.Empty)
            {
                Title = title;
                Artist = artist;
            }
            else
            {
                throw new ArgumentException("Empty values passed in!");
            }
            Genre = genre;
        }

        public MusicFile(string title, string artist, string fileName) : this(title, artist, "other", fileName)
        {
        }

        public override string ToString()
        {
            return $"Title: {Title}\n" +
                   $"Artist: {Artist}\n" +
                   $"Genre: {Genre}\n" +
                   $"Filename: {FileName}"; 
        }
    }
}
