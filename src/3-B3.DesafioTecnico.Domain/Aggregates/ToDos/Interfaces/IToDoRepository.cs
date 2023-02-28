using B3.DesafioTecnico.Domain.Aggregates.ToDos.Entities;
using B3.DesafioTecnico.Domain.Base.Interfaces;

namespace B3.DesafioTecnico.Domain.Aggregates.ToDos.Interfaces
{
    public interface IToDoRepository : IBaseRepository<ToDo, int>
    {
    }
}
