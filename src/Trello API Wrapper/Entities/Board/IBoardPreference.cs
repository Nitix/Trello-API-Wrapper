namespace Trello_API_Wrapper.Entities.Board
{
    public interface IBoardPreference
    {
        string PermissionLevel { get; }

        string Voting { get; }

        string Comments { get; }

        string Invitations { get; }

        bool SelfJoin { get; }

        bool CardCovers { get; }

        string CardAging { get; }

        bool CalendarFeedEnabled { get; }

        string Background { get; }

        //string BackgroundImage { get; }

        //string BackgroundImageScaled { get; }

        bool BackgroundTile { get; }

        string BackgroundBrightness { get; }

        string BackgroundColor { get; }

        bool CanBePublic { get; }

        bool CanBeOrg { get; }

        bool CanBePrivate { get; }

        bool CanInvite { get; }
    }
}
