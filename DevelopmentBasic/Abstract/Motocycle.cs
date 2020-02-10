namespace DevelopmentBasic.Abstract
{
    public class Motocycle : Vehicle
    {
        public override string GetEngineSize()
        {
            return Engine + " liter";
        }

        public override int GetSpeed()
        {
            return Speed;
        }
    }
}