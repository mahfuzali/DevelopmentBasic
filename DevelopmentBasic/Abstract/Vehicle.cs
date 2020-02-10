namespace DevelopmentBasic.Abstract
{
    public abstract class Vehicle
    {
        public string Type { get; set; }

        public double Engine { get; set; }

        public int Speed { get; set; }

        public abstract string GetEngineSize();

        public abstract int GetSpeed();

        public override string ToString()
        {
            return "This is a " + Type.ToLower() + " with " + GetEngineSize() + " engine and " + GetSpeed() + " max speed";
        }
    }
}