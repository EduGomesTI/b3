using B3.DesafioTecnico.Application.Base.Interfaces;
using B3.DesafioTecnico.Application.ToDos.Requests;
using B3.DesafioTecnico.Application.ToDos.Responses;

namespace B3.DesafioTecnico.Application.ToDos.Interfaces;

public interface IToDoService
    : IBaseAddService<ToDoAddRequest, ToDoAddResponse>
    , IbaseDeleteService<ToDoDeleteRequest, ToDoDeleteResponse>
    , IBaseUpdateService<ToDoUpdateRequest, ToDoUpdateResponse>
    , IBaseFindByIdService<ToDoFindByIdRequest, ToDoFindByIdResponse>
    , IBaseFindAllService<ToDoFindAllResponse>
{
}
