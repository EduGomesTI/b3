using B3.Ms.Onboarding.Application.Base.Entities;

namespace B3.Ms.Onboarding.Application.Base.Interfaces
{
    public interface IBaseAddService<TRequest, TResponse>
    where TRequest : BaseRequest
    where TResponse : BaseResponse
    {
        Task<TResponse> AddAsync(TRequest request, CancellationToken cancellationToken);
    }
}
