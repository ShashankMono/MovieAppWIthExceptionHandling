using MovieAppWIthFileStructure.Controler;
using MovieAppWIthFileStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppWIthFileStructure.Presentation
{
    internal class MovieMenu
    {
        public static void DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine($"\nWelcome! to Movies App\n" +
                    $"Choose option\n" +
                    $"1.Display Movies\n" +
                    $"2.Add Movie\n" +
                    $"3.Clear All\n" +
                    $"4.Exit\n");
                int choice = int.Parse(Console.ReadLine());
                RunCasesOfMovieApp(choice);
            }
        }

        public static void RunCasesOfMovieApp(int choice)
        {
            switch (choice)
            {
                case 1:
                    DisplayMovie();
                    break;

                case 2:
                    AddMovie();
                    break;

                case 3:
                    Console.WriteLine(MovieManager.ClearingAllMovieInfo());
                    break;

                case 4:
                    MovieManager.StoreMovie();
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("please choose correct option\n");
                    break;

            }
        }

        public static void DisplayMovie()
        {
            Console.WriteLine("Enter Movie ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine(MovieManager.SendMovieInfo(id));
        }

        public static void AddMovie()
        {
            Console.WriteLine("Enter movie Id:\n");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter movie name:\n");
            string name = Console.ReadLine();
            Console.WriteLine("Enter genre of movie:\n");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter release year of movie:\n");
            int year = int.Parse(Console.ReadLine());

            
            Console.WriteLine(MovieManager.AddingNewMovie(id,name,genre,year));
        }
    }
}
