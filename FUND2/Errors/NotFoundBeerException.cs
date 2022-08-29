using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUND2.Errors
{
    public class NotFoundBeerException :Exception
    {

        public NotFoundBeerException() : base() { }
        public NotFoundBeerException(string message) : base(message) { }
        public NotFoundBeerException(string message, Exception innerException) : base(message, innerException) { }
    }
}
