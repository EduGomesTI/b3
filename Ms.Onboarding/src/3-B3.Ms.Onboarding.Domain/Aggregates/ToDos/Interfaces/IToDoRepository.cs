using B3.Ms.Onboarding.Domain.Aggregates.ToDos.Entities;
using B3.Ms.Onboarding.Domain.Base.Interfaces;

namespace B3.Ms.Onboarding.Domain.Aggregates.ToDos.Interfaces
{
    public interface IToDoRepository : IBaseRepository<ToDo, int>
    {
    }
}
