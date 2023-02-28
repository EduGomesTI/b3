using B3.DesafioTecnico.Data.Repositories.Base;
using B3.DesafioTecnico.Data.Repositories.Base.MySql;
using B3.DesafioTecnico.Domain.Aggregates.ToDos.Entities;
using B3.DesafioTecnico.Domain.Aggregates.ToDos.Interfaces;
using Microsoft.Extensions.Logging;

namespace B3.DesafioTecnico.Data.Repositories.ToDos
{
    public class ToDoRepository : BaseRepository<ToDo, int>, IToDoRepository
    {
        public ToDoRepository(MySqlDbContext context, ILogger<BaseRepository<ToDo, int>> logger) : base(context, logger)
        {
        }
    }
}
