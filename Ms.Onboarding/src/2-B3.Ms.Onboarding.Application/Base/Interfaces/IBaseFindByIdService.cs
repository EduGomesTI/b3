using B3.Ms.Onboarding.Application.Base.Entities;

namespace B3.Ms.Onboarding.Application.Base.Interfaces
{
    public interface IBaseFindByIdService<TRequest, TResponse>
        where TRequest : BaseRequest
        where TResponse : BaseResponse
    {
        Task<TResponse> FindByIdAsync(TRequest request, CancellationToken cancellationToken);
    }
}
