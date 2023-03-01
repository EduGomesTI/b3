namespace B3.Ms.Onboarding.Domain.DomainExceptions
{
    public abstract class DomainException : Exception
    {
        protected DomainException(string message) : base(message) { }
    }
}
