namespace B3.Ms.Update.Domain.DomainExceptions
{
    public class DescriptionEmptyInvalidException : DomainException
    {
        public DescriptionEmptyInvalidException() : base("Deve ser informado uma descrição válida")
        {
        }
    }
}
