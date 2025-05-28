namespace Enemies.nodeles
{
    public class AirEnemy : Enemy
    {
        public AirEnemy(string name):base (name)
        {
           
        }

        public override void Scream()
        {
            Console.WriteLine($"I'm an AirEnemy! Name: {Name}");
        }
    }

}