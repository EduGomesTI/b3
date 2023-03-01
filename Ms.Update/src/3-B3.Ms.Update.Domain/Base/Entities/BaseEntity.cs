namespace B3.Ms.Update.Domain.Base.Entities
{
    public abstract class BaseEntity<TId>
    {
        #region Properties

        public TId? Id { get; set; }

        public List<string> Messages { get; private set; }

        #endregion

        #region Constructors 

        public BaseEntity() => Messages = new List<string>();

        #endregion

        #region Methods

        public void AddMessage(string message) => Messages.Add(message);

        #endregion
    }
}
