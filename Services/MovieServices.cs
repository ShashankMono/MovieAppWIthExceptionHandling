using MovieAppWIthFileStructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppWIthFileStructure.Services
{
    internal class MovieServices
    {
        public static string DisplayMovies(Movie movie)
        {
            return  $"\nMovie Id: {movie.MovieId}\n" +
                    $"Movie Name: {movie.MovieName}\n" +
                    $"Movie Gnere: {movie.MovieGenre}\n" +
                    $"Movie release year: {movie.MovieYear}\n" +
                    $"==================================\n";
        }

        public static string ClearAllMovies(List<Movie> movies)
        {
            movies.Clear();
            return "Cleared All Movies!";
        }
    }
}
