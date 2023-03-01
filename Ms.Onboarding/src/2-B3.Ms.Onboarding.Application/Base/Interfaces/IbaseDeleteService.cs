using B3.Ms.Onboarding.Application.Base.Entities;

namespace B3.Ms.Onboarding.Application.Base.Interfaces
{
    public interface IbaseDeleteService<TRequest, TResponse>
    where TRequest : BaseRequest
    where TResponse : BaseResponse
    {
        Task<TResponse> DeleteAsync(TRequest request, CancellationToken cancellationToken);
    }
}
