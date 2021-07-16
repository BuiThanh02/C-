using System;
using System.Collections.Generic;

namespace FavouriteGameAndMovieList
{
    class Program
    { 
        static void Main(string[] args)
        {
            GameAndMovieCollection<Game> GameList = new GameAndMovieCollection<Game>();
            GameAndMovieCollection<Movie> MovieList = new GameAndMovieCollection<Movie>();
            int a;
            do
            {
                Console.WriteLine("***** List Game and Movie *****\n");
                Console.WriteLine("1. Add new Game.");
                Console.WriteLine("2. Add new Movie.");
                Console.WriteLine("3. Print game list.");
                Console.WriteLine("4. Print movie list.");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter the Number:\n");
                a = Console.Read();
                Console.ReadLine();
                switch (a)
                {
                    case '1':
                        Console.WriteLine("Enter new game name: ");
                        string n1 = Console.ReadLine();
                        Console.WriteLine("Enter new game gerne: ");
                        string g1 = Console.ReadLine();
                        Console.WriteLine("Enter new game developer: ");
                        string d1 = Console.ReadLine();
                        Game newGame = new Game(n1, g1, d1);
                        GameList.AddList(newGame);
                        break;
                    case '2':
                        Console.WriteLine("Enter new movie name: ");
                        string n2 = Console.ReadLine();
                        Console.WriteLine("Enter new movie gerne: ");
                        string g2 = Console.ReadLine();
                        Console.WriteLine("Enter new movie director: ");
                        string d2 = Console.ReadLine();
                        Movie newMovie = new Movie(n2, g2, d2);
                        MovieList.AddList(newMovie);
                        break;
                    case '3':
                        PrintList<Game>(GameList);
                        break;
                    case '4':
                        PrintList<Movie>(MovieList);
                        break;
                }
            }
            while (a != 5);
            Console.WriteLine("Thank you for using our service.");
            return;
        }

        static void PrintList<T>(GameAndMovieCollection<T> MyList)
        {
            foreach (T p in MyList)
                Console.WriteLine(p);
        }
    }
}
