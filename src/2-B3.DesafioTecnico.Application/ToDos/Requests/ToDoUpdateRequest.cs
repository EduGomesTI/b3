using System.ComponentModel.DataAnnotations;
using B3.DesafioTecnico.Application.Base.Entities;

namespace B3.DesafioTecnico.Application.ToDos.Requests;

public class ToDoUpdateRequest : BaseRequest
{
    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O campo {0} é obrigatório.")]
    [StringLength(255, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres", MinimumLength = 6)]
    public string Description { get; set; } = string.Empty;
}
