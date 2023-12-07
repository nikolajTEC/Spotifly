using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifly
{
    public class Song : Base
    {
        private string _title;
        private string _genre;
        private int _lenght; 
        private DateTime _releasedate;
        private List<Artist> _artists;

        public string Title { get => _title; set => _title = value; }
        public string Genre { get => _genre; set => _genre = value; }
        public int Lenght { get => _lenght; set => _lenght = value; }
        public DateTime Releasedate { get => _releasedate; set => _releasedate = value; }
        public List<Artist> Artists { get => _artists; set => _artists = value;}

        public override string ToString()
        {
            return $"Title {Title}\nGenre: {Genre}\n Lenght: {GetTimeFromSeconds(Lenght)}\nArtists: {ShowArtists()}";
        }

        private string ShowArtists()
        {
            string s = string.Empty;
           foreach (Artist artist in Artists) 
            {
                s += artist;
            }
           return s ;
        }

        public TimeSpan GetTimeFromSeconds(int seconds)
        {
            return TimeSpan.FromSeconds(seconds);
        }
    }
}
