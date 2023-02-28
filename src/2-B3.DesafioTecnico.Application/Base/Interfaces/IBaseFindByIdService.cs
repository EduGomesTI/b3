using B3.DesafioTecnico.Application.Base.Entities;

namespace B3.DesafioTecnico.Application.Base.Interfaces
{
    public interface IBaseFindByIdService<TRequest, TResponse>
        where TRequest : BaseRequest
        where TResponse : BaseResponse
    {
        Task<TResponse> FindByIdAsync(TRequest request, CancellationToken cancellationToken);
    }
}
