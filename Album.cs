using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotifly
{
    public class Album : Base
    {
        private string v;
        private List<Song> songs;

        public Album(string title, List<Song> songs)
        {
            Title = title;
            Songs = songs;
        }

        public TimeSpan Length { get { return LengthOfPlayList(); } set { } }
        public string Title { get; set; }
        public List<Song> Songs { get; set; }

        public TimeSpan LengthOfPlayList()
        {
            int length = 0;
            foreach (Song song in Songs)
            {
                length += song.Lenght;
            }
            return TimeSpan.FromSeconds(length);
        }
        public override string ToString()
        {
            string s = $"Title: {Title}\n Length: {Length}\n ";
            foreach (Song song in Songs)
            {
                s += song.Title +"\n";
            }
            return s;
        }
    }
}
