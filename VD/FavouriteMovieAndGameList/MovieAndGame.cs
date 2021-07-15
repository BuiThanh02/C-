using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteMovieAndGameList
{
    public class MovieAndGame
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Gerne { get; set; }

        public MovieAndGame(string name, string type, string gerne)
        {
            Name = name;
            Type = type;
            Gerne = gerne;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Gerne: {Gerne}, Type: {Type}";
        }
    }
}
