using B3.DesafioTecnico.Domain.Aggregates.ToDos.Enums;
using B3.DesafioTecnico.Domain.Base.Entities;
using B3.DesafioTecnico.Domain.DomainExceptions;

namespace B3.DesafioTecnico.Domain.Aggregates.ToDos.Entities
{
    public class ToDo : BaseEntity<int>
    {
        #region Properties

        public string Description { get; private set; } = string.Empty;

        public DateTime CreateDate { get; private set; }

        public DateTime ConclusionDate { get; private set; }

        public Status Status { get; private set; }

        #endregion

        #region Constructors

        public ToDo()
        {

        }       

        public ToDo(int id, string description)
        {
            Id = id;

            ChangeDescription(description);
        }

        public ToDo(string description)
        {
            ChangeDescription(description);

            CreateDate = DateTime.Now;

            Status = Status.New;
        }

        #endregion

        #region Methods

        public void ChangeDescription(string description)
        {
            if(!IsValid(description))
                throw new DescriptionEmptyInvalidException();

            Description = description;
        }

        public void PlannedStatus()
        {
            Status = Status.Planned;
        }

        public void InProgressStatus()
        {
            Status = Status.InProgress;
        }

        public void DoneStatus()
        {
            Status = Status.Done;

            ConclusionDate = DateTime.Now;
        }

        public static bool IsValid(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        #endregion
    }
}
