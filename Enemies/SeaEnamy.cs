namespace Enemies.nodeles
{
    public class SeaEnemy : Enemy
    {
        public SeaEnemy(string name) : base(name)
        {

        }

        public override void Scream()
        {
            Console.WriteLine($"I'm a SeaEnemy! Name: {Name}");
        }
    }
}