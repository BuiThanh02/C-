using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavouriteGameAndMovieList
{
    public class Game
    {
        public string Name { get; set; }
        public string Gerne { get; set; }
        public string Developer { get; set; }

        public Game(string name, string gerne, string developer)
        {
            Name = name;
            Gerne = gerne;
            Developer = developer;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Gerne: {Gerne}, Developer: {Developer}";
        }
    }
}
