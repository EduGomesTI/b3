namespace B3.Ms.Update.Domain.DomainExceptions
{
    public abstract class DomainException : Exception
    {
        protected DomainException(string message) : base(message) { }
    }
}
