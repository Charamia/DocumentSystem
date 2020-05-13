
namespace Animals
{
    public abstract class Animal
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidAnimalException("Name cannot be null or empty");
                }
                if( value.Length < 6)
                {
                    throw new InvalidAnimalException("Name is too short", value);
                }

                this.name = value;
            }
        }

        public virtual string Greet()
        {
            return "I am an animal";
        }

        public override string ToString()
        {
            return this.GetType().Name + " " + this.Name;
        }

        public abstract int GetNumberOfLegs();



    }
}
