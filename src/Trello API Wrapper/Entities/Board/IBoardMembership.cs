namespace Trello_API_Wrapper.Entities.Board
{
    public interface IBoardMembership
    {
        string Id { get; }

        string IdMember { get; }

        string MemberType { get; }

        bool Unconfirmed { get; }

        bool Deactivated { get; }
    }
}