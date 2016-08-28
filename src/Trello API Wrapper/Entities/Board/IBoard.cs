using System;
using System.Collections.Generic;

namespace Trello_API_Wrapper.Entities.Board
{
    public interface IBoard
    {
        string Id { get; }

        string Name { get; }

        string Desc { get; }

        //string DescData { get; } Need further investigation

        bool Closed { get; }

        IOrganization Organization { get; }

        bool Pinned { get; }

        List<IBoardInvitation> Invitations { get; }

        string ShortLink { get; }

        List<IPowerUps> PowerUps { get; }

        DateTime DateLastActivity { get; }

        //List<string> IdTags { get; }

        bool Invited { get; }

        bool Starred { get; }

        Uri URL { get; }

        IBoardPreference Prefs { get; }

        List<IBoardMembership> Memberships { get; }

        bool Subscribed { get; }

        Dictionary<string, string> LabelNames { get; }

        DateTime DateLastView { get; }

        Uri ShortUrl { get; }
    }
}
