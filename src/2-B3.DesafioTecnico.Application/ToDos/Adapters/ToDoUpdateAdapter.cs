using B3.DesafioTecnico.Application.Base.Interfaces;
using B3.DesafioTecnico.Application.ToDos.Responses;
using B3.DesafioTecnico.Domain.Aggregates.ToDos.Entities;
using B3.DesafioTecnico.Domain.Extensions;

namespace B3.DesafioTecnico.Application.ToDos.Adapters
{
    internal class ToDoUpdateAdapter : IBaseResponseAdapter<ToDo, int, ToDoUpdateResponse>
    {
        public ToDoUpdateResponse Adapt(ToDo entity)
        {
            return new ToDoUpdateResponse()
            {
                Id = entity.Id,
                Description = entity.Description,
                CreateDate = entity.CreateDate,
                Status = entity.Status.GetDisplayName()
            };
        }
    }
}
