using System.Text.Json.Serialization;
using B3.Ms.Onboarding.Application.Base.Entities;
using B3.Ms.Onboarding.Domain.Aggregates.ToDos.Enums;

namespace B3.Ms.Onboarding.Application.ToDos.Responses
{
    public class ToDoAddResponse : BaseResponse
    {
        #region Properties

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Description { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime CreateDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Status { get; set; }

        #endregion

        #region Constructors

        public ToDoAddResponse(bool success = true) : base(success)
        {
            Success = success;
        }

        #endregion

        #region Methods



        #endregion
    }
}
