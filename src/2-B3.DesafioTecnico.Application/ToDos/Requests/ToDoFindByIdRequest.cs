using B3.DesafioTecnico.Application.Base.Entities;

namespace B3.DesafioTecnico.Application.ToDos.Requests
{
    public class ToDoFindByIdRequest : BaseRequest
    {
        public int Id { get; set; }
    }
}
