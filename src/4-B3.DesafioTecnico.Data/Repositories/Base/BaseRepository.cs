using B3.DesafioTecnico.Data.Repositories.Base.MySql;
using B3.DesafioTecnico.Domain.Base.Entities;
using B3.DesafioTecnico.Domain.Base.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace B3.DesafioTecnico.Data.Repositories.Base
{
    public abstract class BaseRepository<TEntity, TId> : IBaseRepository<TEntity, TId>
        where TEntity : BaseEntity<TId>
    {

        #region Properties

        private readonly MySqlDbContext _context;

        #endregion

        #region Constructors

        public BaseRepository(MySqlDbContext context)
        {
            _context = context;
        }

        #endregion

        #region Methods

        public async Task<TEntity> AddAsync(TEntity entity, CancellationToken cancellationToken)
        {
            await CreateSet().AddAsync(entity, cancellationToken);

            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }

        public void Delete(TEntity entity)
        {
            CreateSet().Remove(entity);

            _context.SaveChanges();
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

            await _context.SaveChangesAsync(cancellationToken);

            return entity;
        }

        private DbSet<TEntity> CreateSet()
        {
            return _context.Set<TEntity>();
        }

        #endregion       
    }
}
