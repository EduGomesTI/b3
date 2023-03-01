using B3.Ms.Update.Domain.Aggregates.ToDos.Entities;
using B3.Ms.Update.Domain.Base.Interfaces;

namespace B3.Ms.Update.Domain.Aggregates.ToDos.Interfaces
{
    public interface IToDoRepository : IBaseRepository<ToDo, int>
    {
    }
}
