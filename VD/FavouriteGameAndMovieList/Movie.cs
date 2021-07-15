using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteGameAndMovieList
{
    public class Movie
    {
        public string Name { get; set; }
        public string Gerne { get; set; }
        public string Director { get; set; }

        public Movie(string name, string gerne, string director)
        {
            Name = name;
            Gerne = gerne;
            Director = director;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Gerne: {Gerne}, Director: {Director}";
        }
    }
}
