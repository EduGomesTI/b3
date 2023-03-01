using B3.Ms.Onboarding.Application.Base.Entities;

namespace B3.Ms.Onboarding.Application.Base.Interfaces
{
    public interface IBaseFindAllService<TResponse>
    where TResponse : BaseResponse
    {
        Task<TResponse> FindAllAsync(CancellationToken cancellationToken);
    }
}
