using B3.DesafioTecnico.Data.Repositories.Base.MySql;
using B3.DesafioTecnico.Domain.Base.Entities;
using B3.DesafioTecnico.Domain.Base.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace B3.DesafioTecnico.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {

        #region Properties

        private readonly MySqlDbContext _context;
        private readonly ILogger<BaseRepository<TEntity, TId>> _logger;

        #endregion

        #region Constructors

        public BaseRepository(MySqlDbContext context, ILogger<BaseRepository<TEntity, TId>> logger)
        {
            _context = context;
            _logger = logger;
        }

        #endregion

        #region Methods

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await CreateSet().AddAsync(entity, cancellationToken);

            var result = await _context.SaveChangesAsync(cancellationToken);


            if(result == 0)
            {                
                entity.AddMessage("Erro: Objeto não persistido no banco de dados");
            }                

            return entity;
        }

        public void Delete(TEntity entity)
        {
            CreateSet().Remove(entity);

            var result = _context.SaveChanges();

            if(result == 0)      
                _logger.LogWarning("Ocorreu um erro ao excluir o objeto no banco");               
        }

        public async Task<IEnumerable<TEntity>> FindAllAsync(CancellationToken cancellationToken)
        {
            return await CreateSet().AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task<TEntity> FindByIdAsync(TId id, CancellationToken cancellationToken)
        {
            return await CreateSet().AsNoTracking().Where(e => e.Id.Equals(id)).FirstOrDefaultAsync(cancellationToken);
        }

        public async Task<TEntity> UpdateAsync(TEntity entity, CancellationToken cancellationToken)
        {
            _context.Entry(entity).State = EntityState.Modified;

            var result = await _context.SaveChangesAsync(cancellationToken);

            if(result == 0)
            {
                entity.AddMessage("Erro: Objeto não atualizado no banco de dados");
            }

            return entity;
        }

        private DbSet<TEntity> CreateSet()
        {
            return _context.Set<TEntity>();
        }

        #endregion       
    }
}
