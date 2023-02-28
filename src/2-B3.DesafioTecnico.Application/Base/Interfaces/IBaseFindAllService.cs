using B3.DesafioTecnico.Application.Base.Entities;

namespace B3.DesafioTecnico.Application.Base.Interfaces
{
    public interface IBaseFindAllService<TResponse>
    where TResponse : BaseResponse
    {
        Task<TResponse> FindAllAsync(CancellationToken cancellationToken);
    }
}
