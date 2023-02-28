namespace B3.DesafioTecnico.Domain.DomainExceptions
{
    public class DateLessThanTodayInvalidException : DomainException
    {
        public DateLessThanTodayInvalidException() : base("A data da tarefa não pode ser menor que a data atual")
        {
        }
    }
}
