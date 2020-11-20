using System;
using System.Collections.Generic;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            MusicFile music1 = new MusicFile("We are Young", "Bob", "Pop music","Music.mp3");
            MusicFile music2 = new MusicFile("We are Young", "Bob", "Hip music","Lol.mp3");
            Playlist myPlaylist = new Playlist("Susan");
            myPlaylist.AddMusic(music1);
            myPlaylist.AddMusic(music2);

        }
    }
}
