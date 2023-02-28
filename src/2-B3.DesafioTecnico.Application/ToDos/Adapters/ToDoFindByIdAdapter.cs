using B3.DesafioTecnico.Application.Base.Interfaces;
using B3.DesafioTecnico.Application.ToDos.Responses;
using B3.DesafioTecnico.Domain.Aggregates.ToDos.Entities;
using B3.DesafioTecnico.Domain.Extensions;

namespace B3.DesafioTecnico.Application.ToDos.Adapters
{
    internal class ToDoFindByIdAdapter : IBaseResponseAdapter<ToDo, int, ToDoFindByIdResponse>
    {
        public ToDoFindByIdResponse Adapt(ToDo entity)
        {
            return new ToDoFindByIdResponse
            {
                Id = entity.Id,
                Description = entity.Description,
                CreateDate = entity.CreateDate,
                ConclusionDate = entity.ConclusionDate,
                Status = entity.Status.GetDisplayName(),
            };
        }
    }
}
