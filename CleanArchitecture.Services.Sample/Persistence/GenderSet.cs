using CleanArchitecture.Services.Sample.Entities;
using System.Collections;
using System.Linq.Expressions;

namespace CleanArchitecture.Services.Sample.Persistence
{

    internal class GenderSet : IQueryable<Gender>
    {

        #region - - - - - - Fields - - - - - -

        public static readonly Gender Male = new("Male") { ID = 1 };
        public static readonly Gender Female = new("Female") { ID = 2 };
        public static readonly Gender Mayonnaise = new("Mayonnaise") { ID = 3 };

        private static readonly Dictionary<int, Gender> s_Genders = (new[] { Male, Female, Mayonnaise }).ToDictionary(g => g.ID);

        private readonly IQueryable<Gender> m_Genders = s_Genders.Values.AsQueryable();

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

        public static Gender GetGender(int id)
            => s_Genders[id];

        #endregion Methods

    }

}
