using CleanArchitecture.StaticEntity.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.StaticEntity.Persistence
{

    public class PersistenceContext : DbContext, IPersistenceContext
    {

        #region - - - - - - Constructors - - - - - -

        public PersistenceContext(DbContextOptions<PersistenceContext> dbContextOptions) : base(dbContextOptions) { }

        #endregion Constructors

        #region - - - - - - Methods - - - - - -

        IQueryable<TEntity> IPersistenceContext.GetEntities<TEntity>()
            => typeof(TEntity) == typeof(Gender)
                ? (IQueryable<TEntity>)new GenderSet()
                : this.Set<TEntity>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfigurationsFromAssembly(typeof(PersistenceContext).Assembly);

        #endregion Methods

    }

}
