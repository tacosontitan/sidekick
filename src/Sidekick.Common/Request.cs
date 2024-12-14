namespace Sidekick.Common;

/// <summary>
/// Represents a request within the context of the executing application.
/// </summary>
public abstract record Request
{
    /// <summary>
    /// Gets or sets the unique identifier for the request.
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Gets the date and time the request was created.
    /// </summary>
    public DateTimeOffset DateCreated { get; } = DateTimeOffset.UtcNow;
}