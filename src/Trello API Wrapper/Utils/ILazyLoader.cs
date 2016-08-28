using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trello_API_Wrapper.Utils
{
    public interface ILazyLoader<T>
    {
        List<T> Retrieve(int start, int range);
    }
}
