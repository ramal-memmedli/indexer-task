using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer.Exceptions
{
    public class InputIsNullOrEmptyException : Exception
    {
        public InputIsNullOrEmptyException(string message) : base(message)
        {

        }
    }
}
