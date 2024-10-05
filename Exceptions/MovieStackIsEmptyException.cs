using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieAppWIthFileStructure.Exceptions
{
    internal class MovieStackIsEmptyException:Exception
    {
        public MovieStackIsEmptyException(string message) : base(message) { }
    }
}
