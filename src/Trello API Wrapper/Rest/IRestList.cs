using System.Collections.Generic;
using Trello_API_Wrapper.Entities.List;

namespace Trello_API_Wrapper.Rest
{
    public interface IRestList
    {
        List<IList> GetLists(string boardId);

        IList GetList(string listId);
    }
}
