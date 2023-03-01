using B3.Ms.Onboarding.Application.ToDos.Adapters;
using B3.Ms.Onboarding.Application.ToDos.Interfaces;
using B3.Ms.Onboarding.Application.ToDos.Requests;
using B3.Ms.Onboarding.Application.ToDos.Responses;
using B3.Ms.Onboarding.Domain.Aggregates.ToDos.Interfaces;
using B3.Ms.Onboarding.Domain.Base.Messaging;
using Microsoft.Extensions.Logging;

namespace B3.Ms.Onboarding.Application.ToDos.Services
{
    public class ToDoService : IToDoService
    {

        #region Properties

        private readonly IToDoRepository _repository;
        private readonly ILogger<ToDoService> _logger;
        private readonly IMessageBusService _messageBus;

        #endregion

        #region Constructors

        public ToDoService(IToDoRepository repository, ILogger<ToDoService> logger, IMessageBusService messageBus)
        {
            _repository = repository;
            _logger = logger;
            _messageBus = messageBus;
        }

        #endregion

        #region Methods

        public async Task<ToDoAddResponse> AddAsync(ToDoAddRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Adapt request to object");
            var adapter = new ToDoAddAdapter();
            var toDo = adapter.Adapt(request);            

            _logger.LogInformation("Call repository to add the task");
            toDo = await _repository.AddAsync(toDo, cancellationToken);

            if (toDo.Messages.Count > 0)
            {
                _logger.LogWarning("There was an error persisting to the database");
                var responseError = new ToDoAddResponse(false);
                responseError.AddMessages(toDo.Messages);
                return responseError;
            }

            _logger.LogInformation("Adapt object to response");
            var response = adapter.Adapt(toDo);

            _logger.LogInformation("Return response");
            return response;
        }

        public async Task<ToDoDeleteResponse> DeleteAsync(ToDoDeleteRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Call repository to search the task");
            var toDo = await _repository.FindByIdAsync(request.Id, cancellationToken);

            if(toDo is null)
            {
                _logger.LogWarning("No tasks found with tihs Id");
                var responseError = new ToDoDeleteResponse(false);
                var errors = new List<string>() { "Nenhuma tarefa encontrada com este Id" };
                responseError.AddMessages(errors);
                return responseError;
            }

            _logger.LogInformation("Delete task");
            _repository.Delete(toDo);

            _logger.LogInformation("Return response");
            var response = new ToDoDeleteResponse();
            return response;
        }

        public async Task<ToDoFindAllResponse> FindAllAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Call repository to search the tasks");
            var toDos = await _repository.FindAllAsync(cancellationToken);

            if(!toDos.Any())
            {
                _logger.LogWarning("No tasks found");
                var responseError = new ToDoFindAllResponse(false);
                var errors = new List<string>() { "Nenhuma tarefa cadastrada" };
                responseError.AddMessages(errors);
                return responseError;
            }

            _logger.LogInformation("Adapt object to response");
            var adapter = new ToDoFindAllAdapter();
            var response = adapter.Adapt(toDos);

            _logger.LogInformation("Return response");
            return response;
        }

        public async Task<ToDoFindByIdResponse> FindByIdAsync(ToDoFindByIdRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Call repository to search the task");
            var toDo = await _repository.FindByIdAsync(request.Id, cancellationToken);

            if(toDo is null)
            {
                _logger.LogWarning("No tasks found with tihs Id");
                var responseError = new ToDoFindByIdResponse(false);
                var errors = new List<string>() { "Nenhuma tarefa encontrada com este Id" };
                responseError.AddMessages(errors);
                return responseError;
            }

            _logger.LogInformation("Adapt object to response");
            var adapter = new ToDoFindByIdAdapter();
            var response = adapter.Adapt(toDo);

            _logger.LogInformation("Return response");
            return response;
        }

        public async Task<ToDoUpdateStatusResponse> UpdateAsync(ToDoUpdateStatusRequest request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Search the object in database");
            var toDo = await _repository.FindByIdAsync(request.Id, cancellationToken);

            if(toDo is null)
            {
                _logger.LogWarning("No task found with tihs Id");
                var responseError = new ToDoUpdateStatusResponse(false);
                var errors = new List<string>() { "Nenhuma tarefa encontrada com este Id" };
                responseError.AddMessages(errors);
                return responseError;
            }

            _logger.LogInformation("Update status from task");
            toDo.ChangeStatus(request.Status);

            if(toDo.Messages.Count > 0)
            {
                _logger.LogWarning("There is a error with status update");
                var responseError = new ToDoUpdateStatusResponse(false);              
                responseError.AddMessages(toDo.Messages);
                return responseError;
            }

            _logger.LogInformation("Publish message");
            _messageBus.Publish(toDo, "todo-update-status");
            toDo.AddMessage("Atualização do status enviado com sucesso");

            var response = new ToDoUpdateStatusResponse(true);
            response.AddMessages(toDo.Messages);  

            _logger.LogInformation("Return response");
            return response;
        }

        #endregion
    }
}
