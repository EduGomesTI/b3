using B3.DesafioTecnico.Application.Base.Entities;

namespace B3.DesafioTecnico.Application.ToDos.Responses
{
    public class ToDoFindAllResponse : BaseResponse
    {

        #region Properties

        public List<ToDoResponse> ToDos { get; private set; } = new List<ToDoResponse>();

        #endregion

        #region Constructors    

        public ToDoFindAllResponse(bool success = true) : base(success)
        {
            Success = success;           
        }

        #endregion

        #region Methods

        public void AddToDoResponse(IEnumerable<ToDoResponse> toDoResponse) => ToDos.AddRange(toDoResponse);

        #endregion
    }
}
