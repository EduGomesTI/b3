namespace B3.DesafioTecnico.Domain.DomainExceptions
{
    public class DescriptionEmptyInvalidException : DomainException
    {
        public DescriptionEmptyInvalidException() : base("Deve ser informado uma descrição válida")
        {
        }
    }
}
