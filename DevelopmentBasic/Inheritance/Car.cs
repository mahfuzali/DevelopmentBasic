namespace DevelopmentBasic.Inheritance
{
    public class Car : Vehicle
    {
        protected string Model { get; set; }

        public Car(string type, double engine, int speed, string model)
        {
            this.ID = base.GetNextID();
            this.Type = type;
            this.Engine = engine;
            this.Speed = speed;
            this.Model = model;
        }
    }
}