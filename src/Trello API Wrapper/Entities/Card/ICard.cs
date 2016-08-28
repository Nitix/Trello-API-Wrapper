using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trello_API_Wrapper.Entities.Card
{
    public interface ICard
    {
        string Id { get; }

        string IdBoard { get; }

        string IdList { get; }

        bool? CheckItemStates { get; }

        bool Closed { get; }

        DateTime DateLastActivity { get; }

        string Desc { get; }

        //string DescData { get; }

        List<string> IdMembersVoted { get; }

        int IdShort { get; }

        int? IdAttachmentCover { get; }

        List<string> idLabels { get; }

        string Name { get; }

        double Pos { get; }

        string ShortLink { get; }

        //Badge Badge(s???) { get; }

        DateTime? Due { get; }

        List<string> IdCheckList { get; }

        List<string> IdMembers { get; }

        List<string> Labels { get; }

        string ShortUrl { get; }

        bool Subscribed { get; }

        Uri URL { get; }
    }
}
