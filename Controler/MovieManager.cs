using MovieAppWIthFileStructure.Exceptions;
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

            Movie movie = movies.Where(movie => movie.MovieId == id).FirstOrDefault();

            if (movie == null) {
                throw new InvalidIdException("Invalid Id!");
            }
            return movie;
        }
        public static void CheckMovieStackIsEmpty()
        {
            if (movies.Count == 0)
            {
                throw new MovieStackFullException("Movie stack is Empty!");
            }
        }

        public static string SendMovieInfo(Movie movie)
        {
            return MovieServices.DisplayMovies(movie);
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

        public static void CheckMovieStackIsFull()
        {
            if (movies.Count == 5)
            {
                throw new MovieStackFullException("Movie stack is full!");
            }
        }

        public static void StoreMovie()
        {
            Serializer.Serialization(movies);
        }
    }
}
