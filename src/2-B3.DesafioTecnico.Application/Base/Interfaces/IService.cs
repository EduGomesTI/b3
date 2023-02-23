using B3.DesafioTecnico.Application.Base.Entities;

namespace B3.DesafioTecnico.Application.Base.Interfaces;
public interface IService<TRequest, TResponse, TId>
    where TRequest : BaseRequest
    where TResponse : BaseResponse
{
    Task<TResponse> AddAsync(TRequest request, CancellationToken cancellationToken);

    Task<TResponse> UpdateAsync(TRequest request, CancellationToken cancellationToken);

    Task<TResponse> DeleteAsync(TRequest request, CancellationToken cancellationToken);

    Task<TResponse> FindAllAsync(CancellationToken cancellationToken);

    Task<TResponse> FindByIdAsync(TId id, CancellationToken cancellationToken);
}
