using System.ComponentModel.DataAnnotations;

namespace B3.Ms.Update.Domain.Aggregates.ToDos.Enums;
public enum Status : int
{
    [Display(Name = "Nova Tarefa")]
    New = 1,

    [Display(Name = "Tarefa Planejada")]
    Planned = 2,

    [Display(Name = "Tarefa em Andamento")]
    InProgress = 3,

    [Display(Name = "Tarefa Concluída")]
    Done = 4
}
