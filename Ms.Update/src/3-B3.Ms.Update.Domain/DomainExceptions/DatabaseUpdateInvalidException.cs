namespace B3.Ms.Update.Domain.DomainExceptions;

public class DatabaseUpdateInvalidException : DomainException
{
    public DatabaseUpdateInvalidException() : base("There was an error persisting to the database")
    {
    }
}
