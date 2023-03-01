using B3.Ms.Update.Application.Base.Interfaces;
using B3.Ms.Update.Application.ToDos.Requests;

namespace B3.Ms.Update.Application.ToDos.Interfaces;

public interface IToDoService : IBaseUpdateService<ToDoUpdateStatusRequest>

{
}
