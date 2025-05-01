namespace AnimalKingdom
{
    public abstract class Animal
    {
        public virtual string Sound()
        {
            return "Sound = ";
        }

        public interface IMammal
        {
            int NumberOfNipples { get; }
        }

        public interface ICanFly
        {
            int NumberOfWings { get; }
        }
    }
}
