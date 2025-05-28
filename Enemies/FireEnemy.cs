namespace Enemies.nodeles
{
    public class FireEnemy : Enemy
    {
        public FireEnemy(string name) : base(name)
        {

        }

        public override void Scream()
        {
            Console.WriteLine($"I'm a FireEnemy! Name: {Name}");
        }
    }
}