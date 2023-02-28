using B3.DesafioTecnico.Domain.Aggregates.ToDos.Entities;
using Microsoft.EntityFrameworkCore;

namespace B3.DesafioTecnico.Data.Repositories.Base.MySql
{
    public class MySqlDbContext : DbContext
    {

        #region Properties



        #endregion

        #region Constructors

        public MySqlDbContext(DbContextOptions<MySqlDbContext> options) : base(options)
        {
            
        }

        #endregion

        #region DbSets

        public virtual DbSet<ToDo> ToDos { get; set; }

        #endregion

        #region Methods

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .LogTo(x => Console.WriteLine(x))
                .EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MySqlDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder
                .DefaultTypeMapping<string>()
                .IsUnicode(false)
                .HasMaxLength(200);

            base.ConfigureConventions(configurationBuilder);
        }

        #endregion
    }
}
