using DesignPatterns.Domain.Abstractions;
using MediatR;

namespace DesignPatterns.Application.Abstractions.Messaging
{
    internal interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
