using B3.Ms.Onboarding.Application.Base.Interfaces;
using B3.Ms.Onboarding.Application.ToDos.Requests;
using B3.Ms.Onboarding.Application.ToDos.Responses;

namespace B3.Ms.Onboarding.Application.ToDos.Interfaces;

public interface IToDoService
    : IBaseAddService<ToDoAddRequest, ToDoAddResponse>
    , IbaseDeleteService<ToDoDeleteRequest, ToDoDeleteResponse>
    , IBaseUpdateService<ToDoUpdateStatusRequest, ToDoUpdateStatusResponse>
    , IBaseFindByIdService<ToDoFindByIdRequest, ToDoFindByIdResponse>
    , IBaseFindAllService<ToDoFindAllResponse>

{
}
