namespace CleanArchitecture.StaticEntity.Entities
{

    /// <summary>
    /// This would traditionally be implemented as an Enum.
    /// The next logical step is to use the Smart Enum pattern.
    /// Since persistence is not a Domain concern, the next logical step for Smart Enums is to push the 
    /// creation of instances of the Smart Enum into the implementation of the Persistence Context service.
    /// </summary>
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
