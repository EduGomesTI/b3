using B3.DesafioTecnico.Application.Base.Entities;

namespace B3.DesafioTecnico.Application.Base.Interfaces
{
    public interface IbaseDeleteService<TRequest, TResponse>
    where TRequest : BaseRequest
    where TResponse : BaseResponse
    {
        Task<TResponse> DeleteAsync(TRequest request, CancellationToken cancellationToken);
    }
}
