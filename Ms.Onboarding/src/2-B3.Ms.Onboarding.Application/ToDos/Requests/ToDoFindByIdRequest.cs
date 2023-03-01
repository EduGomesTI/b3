using B3.Ms.Onboarding.Application.Base.Entities;

namespace B3.Ms.Onboarding.Application.ToDos.Requests
{
    public class ToDoFindByIdRequest : BaseRequest
    {
        public int Id { get; set; }
    }
}
