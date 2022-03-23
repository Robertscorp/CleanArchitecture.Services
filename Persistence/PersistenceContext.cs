using CleanArchitecture.StaticEntity.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.StaticEntity.Persistence
{

    public class PersistenceContext : DbContext, IPersistenceContext
    {

        #region - - - - - - Methods - - - - - -

        IQueryable<TEntity> IPersistenceContext.GetEntities<TEntity>()
            => typeof(TEntity) == typeof(Gender)
                ? (IQueryable<TEntity>)new GenderSet()
                : this.Set<TEntity>();

        #endregion Methods

    }

}
