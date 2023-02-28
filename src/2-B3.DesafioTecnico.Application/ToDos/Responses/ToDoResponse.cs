using System.Text.Json.Serialization;
using B3.DesafioTecnico.Domain.Aggregates.ToDos.Enums;
using B3.DesafioTecnico.Domain.Extensions;

namespace B3.DesafioTecnico.Application.ToDos.Responses
{
    public class ToDoResponse
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

        public ToDoResponse(int id, string description, DateTime createDate, DateTime conclusionDate, Status status)
        {
            Id = id;
            Description = description;
            CreateDate = createDate;
            ConclusionDate = conclusionDate;
            Status = status.GetDisplayName();
        }

        #endregion

        #region Methods



        #endregion
    }
}
