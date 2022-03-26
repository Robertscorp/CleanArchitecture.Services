using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CleanArchitecture.Services.Sample.Persistence
{

    internal class PersistenceContextFactory : IDesignTimeDbContextFactory<PersistenceContext>
    {

        #region - - - - - - Methods - - - - - -

        public PersistenceContext CreateDbContext(string[] args)
            => new(new DbContextOptionsBuilder<PersistenceContext>()
                        .UseSqlite()
                        .Options);

        #endregion Methods

    }

}
