using B3.DesafioTecnico.Application.Base.Interfaces;
using B3.DesafioTecnico.Application.ToDos.Requests;
using B3.DesafioTecnico.Application.ToDos.Responses;
using B3.DesafioTecnico.Domain.Aggregates.ToDos.Entities;
using B3.DesafioTecnico.Domain.Extensions;

namespace B3.DesafioTecnico.Application.ToDos.Adapters
{
    internal class ToDoAddAdapter 
        : IBaseRequestAdapter<ToDo, int, ToDoAddRequest>
        , IBaseResponseAdapter<ToDo, int, ToDoAddResponse>
    {
        public ToDo Adapt(ToDoAddRequest request)
        {
            return new ToDo(request.Description);
        }

        public ToDoAddResponse Adapt(ToDo entity)
        {
            return new ToDoAddResponse()
            {
                Id = entity.Id,
                Description = entity.Description,
                CreateDate = entity.CreateDate,
                Status = entity.Status.GetDisplayName()
            };
        }
    }
}
