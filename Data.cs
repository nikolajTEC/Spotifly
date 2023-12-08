using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Spotifly
{
    public class Data
    {
        public static List<Song> Songs { get; set; } = new();
        public static List<Album> Albums { get; set; } = new();
        public static List<Artist> Artists { get; set; } = new();
        public static void AddData() 
        {
            Artist artist = new Artist()
            {
                Name = "Test",
                User = "Nikolaj",
                Created = DateTime.Now,
                Country = "Denmark",
                Birthday = new DateTime(2000, 05, 24)
            };
            Artists.Add(artist);
            Artist artist2 = new Artist()
            {
                Name = "Banan",
                User = "Nikolaj",
                Created = DateTime.Now,
                Country = "Denmark",
                Birthday = new DateTime(1995, 10, 5)
            };
            List<Artist> artists = new List<Artist>();
            artists.Add(artist);
            artists.Add(artist2);
            Song song = new Song()
            {
                User = "Nikolaj",
                Created = DateTime.Now,
                Title = "Best song ever",
                Lenght = 242,
                Releasedate = DateTime.Now,
                Artists = artists,
                Genre = "pop"
            };
            Song song2 = new Song()
            {
                User = "Nikolaj",
                Created = DateTime.Now,
                Title = "Best song ever2",
                Lenght = 134,
                Releasedate = DateTime.Now,
                Artists = artists,
                Genre = "rock"
            };
            Songs.AddRange(new List<Song>() { song, song2 });
            Album album = new Album("Bedroom", new List<Song>() { song, song2 });
            album.Songs.Add(song);
            Albums.Add(album);
        }
        public static void AddMoreData()
        {
            Console.WriteLine("What would you like to add?\n 1: Song \n 2: Artist\n 3: Album");
            var asnwer = Convert.ToInt32(Console.ReadLine());
            if (asnwer == 1)
            {
                var song = AddSong();
                Console.WriteLine($"Succesfully added song: {song}");
            }
            if (asnwer == 2)
            {
                var artist = AddArtits();
                Console.WriteLine($"Succesfully added artist: {artist}");
            }
            if ( asnwer == 3)
            {
                AddAlbum();
                Console.WriteLine("Succesfully added album");
            }

        }

        private static void AddAlbum()
        {
            Console.WriteLine("Enter the album details");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            var songs = new List<Song>();
            var answer = "";
            while (answer != "2")
            {
                Console.WriteLine("Would you like to add a new song, or use an existing song?\n1: add new\n 2: add existing");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    AddArtits();
                }
                else if (answer == "2")
                {
                    songs = FindSongs();
                }
            }
            Album album = new Album()
            {
                Title = title,
                Songs = songs
            };

            Albums.Add(album);
        }

        private static List<Song> FindSongs()
        {
            var more = "";
            var songs = new List<Song>();
            Console.WriteLine("choose your songs");
            while (more != "n")
            {
                var counter = 0;
                foreach (var song in Songs)
                {
                    counter++;
                    Console.WriteLine($"{counter}: {song.Title}");
                }
                int choice = Convert.ToInt32(Console.ReadLine());
                songs.Add(Songs[(choice) - 1]);
                Console.WriteLine("press n if you don't want to add more");
                more = Console.ReadLine();
            }
            return songs;
        }

        private static Song AddSong()
        {
            Console.WriteLine("Enter the song details:");

            Console.Write("User: ");
            var user = Console.ReadLine();

            Console.Write("Title: ");
            var title = Console.ReadLine();

            Console.Write("Length: ");
            var length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Genre: ");
            var genre = Console.ReadLine();

            List<Artist> artits = new List<Artist>();
            var answer = "";
            while (answer != "2")
            {
                Console.WriteLine("Would you like to add a new artist, or use an existing artist?\n1: add new\n 2: add existing");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    AddArtits();
                }
                else if (answer == "2")
                {
                    artits = FindArtits();
                }
            }


            Song song = new Song()
            {
                User = user,
                Created = DateTime.Now,
                Title = title,
                Lenght = length,
                Releasedate = DateTime.Now,
                Artists = artits,
                Genre = genre
            };
            Songs.Add(song);
            return song;
        }

        private static List<Artist> FindArtits()
        {
            
            var more = "";
            var artits = new List<Artist>();
            Console.WriteLine("choose your artists");
            while (more != "n")
            {
                var counter = 0;
                foreach (var artist in Artists)
                {
                    counter++;
                    Console.WriteLine($"{counter}: {artist.Name}");
                }
                int choice = Convert.ToInt32(Console.ReadLine());
                artits.Add(Artists[(choice) - 1]);
                Console.WriteLine("press n if you don't want to add more");
                more = Console.ReadLine();
            }
            return artits;
        }

        private static Artist AddArtits()
        {
            List<Artist> artits = new List<Artist>();
            Console.WriteLine("Enter the artist details:");

            Console.Write("name: ");
            var name = Console.ReadLine();

            Console.Write("country: ");
            var country = Console.ReadLine();

            Console.Write("birthday: ");
            var birthday = Convert.ToDateTime(Console.ReadLine());

            Artist artist = new Artist()
            {
                Name = name,
                Country = country,
                Birthday = birthday
            };
            Artists.Add(artist);
            return artist;
        }
    }
}
