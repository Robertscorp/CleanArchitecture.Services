namespace CleanArchitecture.Services.Sample.Persistence
{

    public interface IPersistenceContext
    {

        #region - - - - - - Methods - - - - - -

        IQueryable<TEntity> GetEntities<TEntity>() where TEntity : class;

        #endregion Methods

    }

}
