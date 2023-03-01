using B3.Ms.Onboarding.Application.Base.Entities;
using B3.Ms.Onboarding.Domain.Base.Entities;

namespace B3.Ms.Onboarding.Application.Base.Interfaces;
internal interface IBaseRequestAdapter<TEntity, TId, TRequest>
    where TEntity : BaseEntity<TId>
    where TRequest : BaseRequest
{
    TEntity Adapt(TRequest request);
}
