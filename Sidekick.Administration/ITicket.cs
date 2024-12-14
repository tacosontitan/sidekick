namespace Sidekick.Administration;

/// <summary>
/// Defines members to represent a basic ticket.
/// </summary>
public interface ITicket
{
    /// <summary>
    /// The unique identifier for the ticket.
    /// </summary>
    public Guid Id { get; }
}