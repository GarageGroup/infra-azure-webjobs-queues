using System;
using System.Diagnostics.CodeAnalysis;

namespace GGroupp.Infra;

public sealed record class QueueItemIn
{
    public QueueItemIn(string id, [AllowNull] string message, Guid invocationId, int retryCount, int maxRetryCount)
    {
        Id = id ?? string.Empty;
        Message = message ?? string.Empty;
        InvocationId = invocationId;
        RetryCount = retryCount;
        MaxRetryCount = maxRetryCount;
    }

    public string Id { get; }

    public string Message { get; }

    public Guid InvocationId { get; }

    public int RetryCount { get; }

    public int MaxRetryCount { get; }
}