using B3.Ms.Update.Application.Base.Entities;

namespace B3.Ms.Update.Application.Base.Interfaces
{
    public interface IBaseUpdateService<TRequest>
    where TRequest : BaseRequest
    { 
        void UpdateAsync(TRequest request, CancellationToken cancellationToken);
    }
}
