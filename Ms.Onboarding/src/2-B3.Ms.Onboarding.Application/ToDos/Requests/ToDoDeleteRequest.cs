using System.ComponentModel.DataAnnotations;
using B3.Ms.Onboarding.Application.Base.Entities;

namespace B3.Ms.Onboarding.Application.ToDos.Requests
{
    public class ToDoDeleteRequest : BaseRequest
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public int Id { get; set; }
    }
}
