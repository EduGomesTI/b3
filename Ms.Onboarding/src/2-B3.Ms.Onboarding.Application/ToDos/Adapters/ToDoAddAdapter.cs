using B3.Ms.Onboarding.Application.Base.Interfaces;
using B3.Ms.Onboarding.Application.ToDos.Requests;
using B3.Ms.Onboarding.Application.ToDos.Responses;
using B3.Ms.Onboarding.Domain.Aggregates.ToDos.Entities;
using B3.Ms.Onboarding.Domain.Extensions;

namespace B3.Ms.Onboarding.Application.ToDos.Adapters
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
