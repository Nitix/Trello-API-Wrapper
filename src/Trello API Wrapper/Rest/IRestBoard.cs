using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trello_API_Wrapper.Entities.Board;

namespace Trello_API_Wrapper.Rest
{
    public interface IRestBoard
    {
        IBoard GetBoard(string id);

        IBoard GetAllBoards();
    }
}
