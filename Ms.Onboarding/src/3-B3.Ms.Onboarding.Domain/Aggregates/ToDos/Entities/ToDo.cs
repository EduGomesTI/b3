using B3.Ms.Onboarding.Domain.Aggregates.ToDos.Enums;
using B3.Ms.Onboarding.Domain.Base.Entities;
using B3.Ms.Onboarding.Domain.DomainExceptions;

namespace B3.Ms.Onboarding.Domain.Aggregates.ToDos.Entities
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

        public void ChangeStatus(int status)
        { 
            switch(status)
            {
                case 1:
                    {
                        AddMessage("Esta tarefa já está com o status de Nova Tarefa");
                        break;
                    }
                case 2:
                    {
                        PlannedStatus();
                        break;
                    }
                case 3:
                    {
                        InProgressStatus();
                        break;
                    }
                    case 4:
                    {
                        DoneStatus();
                        break;
                    }
                default:
                    {
                        AddMessage("Opção de status inválida");
                        break;
                    }
            }       
        }

        private void PlannedStatus()
        {
            Status = Status.Planned;
        }

        private void InProgressStatus()
        {
            Status = Status.InProgress;
        }

        private void DoneStatus()
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
