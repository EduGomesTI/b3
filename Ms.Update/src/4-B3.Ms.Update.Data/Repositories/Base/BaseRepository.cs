using B3.Ms.Update.Data.Repositories.Base.MySql;
using B3.Ms.Update.Domain.Base.Entities;
using B3.Ms.Update.Domain.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace B3.Ms.Update.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {

        #region Properties

        private readonly MySqlDbContext _context;
        private readonly ILogger<BaseRepository<TEntity, TId>> _logger;

        #endregion

        #region Constructors

        public BaseRepository(IServiceProvider serviceProvider, ILogger<BaseRepository<TEntity, TId>> logger)
        {
            _context = serviceProvider.CreateScope().ServiceProvider.GetRequiredService<MySqlDbContext>();
            _logger = logger;
        }

        #endregion

        #region Methods

        public void Update(TEntity entity, CancellationToken cancellationToken)
        {
            _logger.LogInformation($"Change state of entity {entity.Id}");
            _context.Entry(entity).State = EntityState.Modified;

            _logger.LogInformation($"Updated {entity.Id}");
            _context.SaveChanges();

            _logger.LogInformation($"Detached {entity.Id}");
            _context.Entry(entity).State = EntityState.Detached;                      
        }      

        #endregion       
    }
}
