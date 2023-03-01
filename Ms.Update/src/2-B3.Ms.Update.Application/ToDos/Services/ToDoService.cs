using B3.Ms.Update.Application.ToDos.Adapters;
using B3.Ms.Update.Application.ToDos.Interfaces;
using B3.Ms.Update.Application.ToDos.Requests;
using B3.Ms.Update.Domain.Aggregates.ToDos.Interfaces;
using B3.Ms.Update.Domain.DomainExceptions;
using Microsoft.Extensions.Logging;

namespace B3.Ms.Update.Application.ToDos.Services
{
    public class ToDoService : IToDoService
    {

        #region Properties

        private readonly IToDoRepository _repository;
        private readonly ILogger<ToDoService> _logger;

        #endregion

        #region Constructors

        public ToDoService(IToDoRepository repository, ILogger<ToDoService> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        #endregion

        #region Methods 

        public void UpdateAsync(ToDoUpdateStatusRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Adapt request to object");
            var adapter = new ToDoUpdateAdapter();
            var toDo = adapter.Adapt(request);

            _logger.LogInformation("Call repository to update the task");
            _repository.UpdateAsync(toDo, cancellationToken);

            if(toDo.Messages.Count > 0)
                throw new DatabaseUpdateInvalidException();           
        }

        #endregion
    }
}
