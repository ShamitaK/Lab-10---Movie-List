using System;
using System.Collections.Generic;

namespace Lab_10___Movie_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieGenre = new List<Movie>
            {
                new Movie("It", "Horror"),
                new Movie("Insidious", "Horror"),
                new Movie("Insidious", "Horror"),
                new Movie("Avatar", "SciFi"),
                new Movie("Jurassic World", "SciFi"),
                new Movie("Titanic", "Drama"),
                new Movie("Pursuit Of Happiness", "Drama"),
                new Movie("Spirited Away", "Animated"),
                new Movie("Lion King", "Animated"),
                new Movie("How To Train Your Dragon", "Animated"),
            };
            Movie.ListMovies();


            bool Continue = true;

            while (Continue == true)
            {
                Console.WriteLine("What movie genre are you intrigued by? \n");
                string movieType = Console.ReadLine().ToLower();

                try
                {
                    foreach (var movie in movieGenre)
                    {
                        if (movieType == "1" || movieType == "horror")
                        {
                            if (movie.Category == "Horror")
                            {
                                Console.WriteLine(movie.Title);
                            }
                        }
                        else if (movieType == "2" || movieType == "scifi")
                        {
                            if (movie.Category == "SciFi")
                            {
                                Console.WriteLine(movie.Title);
                            }
                        }
                        else if (movieType == "3" || movieType == "drama")
                        {
                            if (movie.Category == "Drama")
                            {
                                Console.WriteLine(movie.Title);
                            }
                        }
                        else if (movieType == "4" || movieType == "animated")
                        {
                            if (movie.Category == "Animated")
                            {
                                Console.WriteLine(movie.Title);
                            }
                        }
                        else if (movieType == "5" || movieType == "Continue")
                        {
                            Console.WriteLine("Awesome! Let's try again!");
                        }
                        else if (movieType == "6" || movieType == "I'm done")
                        {
                            if (movie.Category == "I'm Done")
                            {
                                Console.WriteLine("Thanks for inquiry!");
                                Continue = false;
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Uh Oh, something went wrong. Please select: \n  \n1. Horror \n2. SciFi \n3. Drama \n4. Animated \n5.Continue \n6. I'm done");
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}


