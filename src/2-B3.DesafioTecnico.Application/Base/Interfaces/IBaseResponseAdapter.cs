using B3.DesafioTecnico.Application.Base.Entities;
using B3.DesafioTecnico.Domain.Base.Entities;

namespace B3.DesafioTecnico.Application.Base.Interfaces;
internal interface IBaseResponseAdapter<TEntity, TId, TResponse>
    where TEntity : BaseEntity<TId>
    where TResponse : BaseResponse 
{
    TResponse Adapt(TEntity entity);
}
