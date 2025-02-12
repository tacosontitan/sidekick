namespace Sidekick.Administration;

/// <summary>
/// Defines members for interacting with tickets.
/// </summary>
public interface ITicketService
{
    /// <summary>
    /// Adds a comment to the specified ticket.
    /// </summary>
    /// <param name="ticket">The ticket to add specified <paramref name="comment"/> to.</param>
    /// <param name="comment">The comment to add to the ticket.</param>
    /// <param name="cancellationToken">A token for cancelling the operation.</param>
    /// <returns>A task describing the state of the operation.</returns>
    public Task AddComment(
        ITicket ticket,
        string comment,
        CancellationToken cancellationToken);

    /// <summary>
    ///     Adds the specified <paramref name="comment"/> and <paramref name="attachment"/> to the specified
    ///     <paramref name="ticket"/>.
    /// </summary>
    /// <param name="ticket">The ticket to add specified <paramref name="comment"/> to.</param>
    /// <param name="comment">The comment to add to the ticket.</param>
    /// <param name="attachment">The attachment to add to the ticket as part of the <paramref name="comment"/>.</param>
    /// <param name="cancellationToken">A token for cancelling the operation.</param>
    /// <returns>A task describing the state of the operation.</returns>
    public Task AddComment(
        ITicket ticket,
        string comment,
        byte[] attachment,
        CancellationToken cancellationToken);
}