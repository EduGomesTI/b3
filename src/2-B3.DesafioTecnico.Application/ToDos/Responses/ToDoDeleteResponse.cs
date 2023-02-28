using B3.DesafioTecnico.Application.Base.Entities;

namespace B3.DesafioTecnico.Application.ToDos.Responses
{
    public class ToDoDeleteResponse : BaseResponse
    {

        #region Properties



        #endregion

        #region Constructors

        public ToDoDeleteResponse(bool success = true) : base(success) => Success = success;        

        #endregion

        #region Methods



        #endregion
    }
}
