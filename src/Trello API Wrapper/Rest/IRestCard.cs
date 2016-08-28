using System.Collections.Generic;
using Trello_API_Wrapper.Entities.Card;

namespace Trello_API_Wrapper.Rest
{
    public interface IRestCard
    {
        List<ICard> GetCards(string idList);

        ICard GetCard(string idCard);
    }
}
