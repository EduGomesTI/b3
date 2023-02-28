namespace B3.DesafioTecnico.Domain.DomainExceptions
{
    public abstract class DomainException : Exception
    {
        protected DomainException(string message) : base(message) { }
    }
}
