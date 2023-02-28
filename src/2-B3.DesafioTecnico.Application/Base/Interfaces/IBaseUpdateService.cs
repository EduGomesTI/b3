using B3.DesafioTecnico.Application.Base.Entities;

namespace B3.DesafioTecnico.Application.Base.Interfaces
{
    public interface IBaseUpdateService<TRequest, TResponse>
    where TRequest : BaseRequest
    where TResponse : BaseResponse
    { 
        Task<TResponse> UpdateAsync(TRequest request, CancellationToken cancellationToken);
    }
}
