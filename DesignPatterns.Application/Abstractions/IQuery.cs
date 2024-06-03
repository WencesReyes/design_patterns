using DesignPatterns.Domain.Abstractions;
using MediatR;

namespace DesignPatterns.Application.Abstractions
{
    internal interface IQuery<TResponse> : IRequest<Result<TResponse>> 
    {
    }
}
