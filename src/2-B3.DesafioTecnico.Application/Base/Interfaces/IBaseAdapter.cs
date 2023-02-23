using B3.DesafioTecnico.Application.Base.Entities;
using B3.DesafioTecnico.Domain.Base.Entities;

namespace B3.DesafioTecnico.Application.Base.Interfaces;
public interface IBaseAdapter<TEntity, TId, TRequest, TResponse>
    where TEntity : BaseEntity<TId>
    where TRequest : BaseRequest
    where TResponse : BaseResponse {
    TEntity Adapt(TRequest request);

    TResponse Adapt(TEntity entity);
}
