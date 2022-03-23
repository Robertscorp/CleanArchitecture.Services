namespace CleanArchitecture.StaticEntity.Entities
{

    public class Gender
    {

        #region - - - - - - Constructors - - - - - -

        public Gender(string name)
            => this.Name = name;

        #endregion Constructors

        #region - - - - - - Properties - - - - - -

        public int ID { get; set; }

        public string Name { get; set; }

        #endregion Properties

    }

}
