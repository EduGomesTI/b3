using B3.Ms.Onboarding.Application.Base.Entities;

namespace B3.Ms.Onboarding.Application.Base.Interfaces
{
    public interface IBaseUpdateService<TRequest, TResponse>
    where TRequest : BaseRequest
    where TResponse : BaseResponse
    { 
        Task<TResponse> UpdateAsync(TRequest request, CancellationToken cancellationToken);
    }
}
