using CleanArchitecture.StaticEntity.Entities;
using System.Collections;
using System.Linq.Expressions;

namespace CleanArchitecture.StaticEntity.Persistence
{

    public class GenderSet : IQueryable<Gender>
    {

        #region - - - - - - Fields - - - - - -

        private static Dictionary<int, Gender> s_Genders = (new[]
        {
            new Gender("Male") { ID = 1 },
            new Gender("Female") { ID = 2 },
            new Gender("Mayonnaise") { ID = 3 },
        }).ToDictionary(g => g.ID);

        private IQueryable<Gender> m_Genders = s_Genders.Values.AsQueryable();

        #endregion Fields

        #region - - - - - - Properties - - - - - -

        Type IQueryable.ElementType => this.m_Genders.ElementType;

        Expression IQueryable.Expression => this.m_Genders.Expression;

        IQueryProvider IQueryable.Provider => this.m_Genders.Provider;

        #endregion Properties

        #region - - - - - - Methods - - - - - -

        IEnumerator<Gender> IEnumerable<Gender>.GetEnumerator()
            => this.m_Genders.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => ((IEnumerable)this.m_Genders).GetEnumerator();

        #endregion Methods

    }

}
