namespace B3.Ms.Onboarding.Domain.DomainExceptions
{
    public class DescriptionEmptyInvalidException : DomainException
    {
        public DescriptionEmptyInvalidException() : base("Deve ser informado uma descrição válida")
        {
        }
    }
}
