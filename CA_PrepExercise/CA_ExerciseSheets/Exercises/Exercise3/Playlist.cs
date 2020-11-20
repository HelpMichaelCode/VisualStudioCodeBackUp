using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise3
{
    public class Playlist 
    {
        public string PlaylistName { get; set; }
        private List<MusicFile> myList;
        public List<MusicFile> ReadOnlyMusicFiles
        {
            get
            {
                return myList;
            }
        }

        public Playlist(string playListName)
        {
            PlaylistName = playListName;
            myList = new List<MusicFile>();
        }

        public void AddMusic(MusicFile myMusic)
        {
            myList.Add(myMusic);
            // Look back on how this work...
            // A, B, C, D, A, A, B, B
            // A, A, A, B, B, B, C, D
            // A : 3
            // B : 3
            // C : 1
            // D : 1

            // [A, B]
            // We Are Young, We Are Young, We Are Not Young
            // Bob Marley, Bob Marley, Michale Jack


            // Bob Marley : 2
            // michael Jack : 1

            // We Are Young : 2
            // We Are Not Young : 1


            var duplicatedForTitle = from musicList in myList group musicList by musicList.Title into g where g.Count() > 1 select g.Key;
            var duplicatedForArtist = from musicList in myList group musicList by musicList.Artist into g where g.Count() > 1 select g.Key;

            if (duplicatedForTitle.Contains(myMusic.Title) && duplicatedForArtist.Contains(myMusic.Artist))
            {
                throw new ArgumentException($"{myMusic.Title} && {myMusic.Artist} are duplicated values!");
            }   
        }

        public 
    }
}
