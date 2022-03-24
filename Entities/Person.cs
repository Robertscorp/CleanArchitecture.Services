namespace CleanArchitecture.StaticEntity.Entities
{

    public class Person
    {

        #region - - - - - - Constructors - - - - - -

        public Person(Gender gender, string name)
        {
            this.Gender = gender;
            this.Name = name;
        }

        #endregion Constructors

        #region - - - - - - Properties - - - - - -

        public int ID { get; set; }

        public Gender Gender { get; set; }

        public string Name { get; set; }

        #endregion Properties

    }

}
