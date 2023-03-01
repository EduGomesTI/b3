using B3.Ms.Update.Data.Repositories.Base;
using B3.Ms.Update.Domain.Aggregates.ToDos.Entities;
using B3.Ms.Update.Domain.Aggregates.ToDos.Interfaces;
using Microsoft.Extensions.Logging;

namespace B3.Ms.Update.Data.Repositories.ToDos
{
    public class ToDoRepository : BaseRepository<ToDo, int>, IToDoRepository
    {
        public ToDoRepository(IServiceProvider serviceProvider, ILogger<BaseRepository<ToDo, int>> logger) : base(serviceProvider, logger)
        {
        }
    }
}
