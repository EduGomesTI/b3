using B3.Ms.Update.Application.Base.Entities;
using B3.Ms.Update.Domain.Aggregates.ToDos.Enums;

namespace B3.Ms.Update.Application.ToDos.Requests;

public class ToDoUpdateStatusRequest : BaseRequest
{
    public int Id { get; set; }

    public string Description { get; set; }

    public DateTime CreateDate { get; set; }

    public DateTime ConclusionDate { get; set; }

    public Status Status { get; set; }
}
