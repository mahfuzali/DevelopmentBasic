namespace DevelopmentBasic.Inheritance
{
    public class Vehicle
    {
        private static int currentID;

        protected int ID { get; set; }

        protected string Type { get; set; }

        protected double Engine { get; set; }

        protected int Speed { get; set; }

        public Vehicle()
        {
            ID = 0;
            Type = "Default type";
            Engine = 0.0;
        }

        public Vehicle(string type, double engine, int speed)
        {
            this.ID = GetNextID();
            this.Type = type;
            this.Engine = engine;
            this.Speed = speed;
        }

        protected int GetNextID()
        {
            return ++currentID;
        }

        public void Update(double engine, int speed)
        {
            this.Engine = engine;
            this.Speed = speed;
        }

        public override string ToString()
        {
            return $"This is a {this.Type.ToLower()} with {this.Engine} liter engine and {this.Speed} max speed";
        }
    }
}