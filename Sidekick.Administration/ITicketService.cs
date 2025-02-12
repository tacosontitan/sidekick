namespace Sidekick.Administration;

/// <summary>
/// Defines members for interacting with tickets.
/// </summary>
public interface ITicketService
{
    /// <summary>
    /// Gets a ticket with the specified <paramref name="id"/>.
    /// </summary>
    /// <param name="id">The unique identifier of the ticket to get.</param>
    /// <param name="cancellationToken">A token for cancelling the operation.</param>
    /// <typeparam name="TTicket">Specifies the type of ticket to get.</typeparam>
    /// <returns>A task describing the state of the operation and containing the ticket in its result.</returns>
    public Task<TTicket> GetTicket<TTicket>(
        Guid id,
        CancellationToken cancellationToken)
        where TTicket : ITicket;
    
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