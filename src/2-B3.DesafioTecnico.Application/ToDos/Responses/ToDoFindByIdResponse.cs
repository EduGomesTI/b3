using B3.DesafioTecnico.Application.Base.Entities;
using B3.DesafioTecnico.Domain.Aggregates.ToDos.Enums;
using System.Text.Json.Serialization;

namespace B3.DesafioTecnico.Application.ToDos.Responses
{
    public class ToDoFindByIdResponse : BaseResponse
    {
        #region Properties

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public int Id { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Description { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime CreateDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public DateTime ConclusionDate { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public string Status { get; set; }

        #endregion

        #region Constructors

        public ToDoFindByIdResponse(bool success = true) : base(success)
        {
            Success = success;
        }

        #endregion

        #region Methods



        #endregion
    }
}
