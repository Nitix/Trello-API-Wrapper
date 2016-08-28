using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trello_API_Wrapper.Utils
{
    public class ReadOnlyListException : NotImplementedException
    {
        public ReadOnlyListException()
        {
        }

        public ReadOnlyListException(string message)
        : base(message)
    {
        }

        public ReadOnlyListException(string message, Exception inner)
        : base(message, inner)
    {
        }
    }
}
