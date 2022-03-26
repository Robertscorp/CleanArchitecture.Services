using System.Linq;

namespace CleanArchitecture.Application.Abstractions
{

    public interface IPersistenceContext
    {

        #region - - - - - - Methods - - - - - -

        IQueryable<TEntity> GetEntities<TEntity>() where TEntity : class;

        #endregion Methods

    }

}
