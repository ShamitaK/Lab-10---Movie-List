using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_10___Movie_List
{
    class Movie
    {
        //fields
        private string title;
        private string category;

        //properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public Movie()
        {

        }

        public Movie(string _title, string _category)
        {
            title = _title;
            category = _category;
        }

        public static void ListMovies()
        {//FIGURE OUT WHY THIS DIDNT WORK!!

            //List<string> ListMovies = new List<string>();
            //for (int i = 0; i < movieList.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1}. {movieList[i]}");
            //}

            Console.WriteLine("Pick a Genre: \n1. Horror \n2. SciFi \n3. Drama \n4. Animated \n5.Continue \n6. I'm done");
        }


        public static bool Continue()
        {
            //Checking if the user would like to continue...
            Console.WriteLine("Continue: y/n");
            string userContinue = Console.ReadLine().ToLower();


            if (userContinue == "y" || userContinue == "yes")
            {
                Console.Clear();
                return true;
            }
            else if (userContinue == "n" || userContinue == "no")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Invalid Number, Please try again. y/n");
                //This is an example of a RECURSION because it is calling the same method inside of itself. It will only stop once they hit y or yes.
                return Continue();
            }
        }
    }
}
