using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trello_API_Wrapper.Entities.Card;

namespace Trello_API_Wrapper.Entities.List
{
    public interface IList
    {
        string Id { get; }

        string Name { get; }

        bool Closed { get; }

        double Pos { get; }
        
        bool Subscribed { get; }

        List<ICard> Cards { get; }
    }
}
