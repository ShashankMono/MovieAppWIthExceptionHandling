using MovieAppWIthFileStructure.Models;
using MovieAppWIthFileStructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MovieAppWIthFileStructure.Controler
{
    internal class MovieManager
    {
        static List<Movie> movies = Serializer.Deserialization();
        
        public static Movie FindMovie(int id)
        {
            if(movies.Count != 0)
            {
                return movies.Where(movie => movie.MovieId == id).FirstOrDefault();
            }
            return null;
        }

        public static string SendMovieInfo(int id)
        {
            Movie movie = FindMovie(id);
            if(movie != null)
            {
                return MovieServices.DisplayMovies(movie);
            }
            return "Enter Valid Id!";
        }

        public static string ClearingAllMovieInfo()
        {
            return MovieServices.ClearAllMovies(movies);
        }

        public static string AddingNewMovie(int mId,string mName,string mGenre,int mYear)
        {
            Movie movie = new Movie(mId, mName, mGenre, mYear);
            movies.Add(movie);
            return "Movie Added Sucessfully!";
        }

        public static void StoreMovie()
        {
            Serializer.Serialization(movies);
        }
    }
}
