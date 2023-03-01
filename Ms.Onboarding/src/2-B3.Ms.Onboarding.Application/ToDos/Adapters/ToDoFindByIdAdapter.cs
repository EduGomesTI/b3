using B3.Ms.Onboarding.Application.Base.Interfaces;
using B3.Ms.Onboarding.Application.ToDos.Responses;
using B3.Ms.Onboarding.Domain.Aggregates.ToDos.Entities;
using B3.Ms.Onboarding.Domain.Extensions;

namespace B3.Ms.Onboarding.Application.ToDos.Adapters
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
