using B3.Ms.Onboarding.Application.Base.Entities;

namespace B3.Ms.Onboarding.Application.ToDos.Responses
{
    public class ToDoUpdateStatusResponse : BaseResponse
    {
        #region Properties

        #endregion

        #region Constructors

        public ToDoUpdateStatusResponse(bool success = true) : base(success)
        {
            Success = success;
        }

        #endregion

        #region Methods



        #endregion
    }
}
