using B3.Ms.Update.Application.Base.Interfaces;
using B3.Ms.Update.Application.ToDos.Requests;
using B3.Ms.Update.Domain.Aggregates.ToDos.Entities;

namespace B3.Ms.Update.Application.ToDos.Adapters
{
    internal class ToDoUpdateAdapter 
        : IBaseRequestAdapter<ToDo, int, ToDoUpdateStatusRequest>  
    {
        public ToDo Adapt(ToDoUpdateStatusRequest request)
        {
            return new ToDo(request.Id, request.Description, request.CreateDate, request.ConclusionDate, request.Status);            
        }   
    }
}
