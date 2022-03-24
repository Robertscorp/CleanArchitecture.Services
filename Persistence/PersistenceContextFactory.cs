using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CleanArchitecture.StaticEntity.Persistence
{

    internal class PersistenceContextFactory : IDesignTimeDbContextFactory<PersistenceContext>
    {

        #region - - - - - - Methods - - - - - -

        public PersistenceContext CreateDbContext(string[] args)
            => new(new DbContextOptionsBuilder<PersistenceContext>()
                        .UseSqlite("Data Source=blog.db")
                        .Options);

        #endregion Methods

    }

}
