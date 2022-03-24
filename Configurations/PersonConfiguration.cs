using CleanArchitecture.StaticEntity.Entities;
using CleanArchitecture.StaticEntity.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArchitecture.StaticEntity.Configurations
{

    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {

        #region - - - - - - Methods - - - - - -

        void IEntityTypeConfiguration<Person>.Configure(EntityTypeBuilder<Person> builder)
        {
            _ = builder.HasData(new[]
            {
                new Person(GenderSet.Male, "Hugh Mann") { ID= 1 },
                new Person(GenderSet.Female, "Amanda Huggen-Kiss") { ID= 2 },
                new Person(GenderSet.Mayonnaise, "GennY McStable") { ID= 3 }
            });

            _ = builder.ToTable("Person");

            _ = builder.HasKey(p => p.ID);
            _ = builder.Property(p => p.Gender).HasConversion(g => g.ID, dbVal => GenderSet.GetGender(dbVal));
            _ = builder.Property(p => p.Name);
        }

        #endregion Methods

    }

}
