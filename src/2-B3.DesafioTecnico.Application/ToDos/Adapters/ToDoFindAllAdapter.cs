using B3.DesafioTecnico.Application.ToDos.Responses;
using B3.DesafioTecnico.Domain.Aggregates.ToDos.Entities;

namespace B3.DesafioTecnico.Application.ToDos.Adapters
{
    internal class ToDoFindAllAdapter
    {
        public ToDoFindAllResponse Adapt(IEnumerable<ToDo> entities)
        {
            var toDoresponses = new List<ToDoResponse>();

            foreach(var entity in entities)
            {
                toDoresponses.Add(new ToDoResponse
                (entity.Id,
                 entity.Description,
                 entity.CreateDate,
                 entity.ConclusionDate,
                 entity.Status));
            }

            var result = new ToDoFindAllResponse(true);
            result.AddToDoResponse(toDoresponses);
            return result;
        }
    }
}
