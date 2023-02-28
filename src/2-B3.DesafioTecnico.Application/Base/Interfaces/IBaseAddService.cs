using B3.DesafioTecnico.Application.Base.Entities;

namespace B3.DesafioTecnico.Application.Base.Interfaces
{
    public interface IBaseAddService<TRequest, TResponse>
    where TRequest : BaseRequest
    where TResponse : BaseResponse
    {
        Task<TResponse> AddAsync(TRequest request, CancellationToken cancellationToken);
    }
}
