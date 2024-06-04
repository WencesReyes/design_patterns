using DesignPatterns.Domain.Abstractions;
using MediatR;

namespace DesignPatterns.Application.Abstractions.Messaging
{
    internal interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
        where TQuery : IQuery<TResponse>
    {
    }
}
