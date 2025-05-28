namespace Comando.models
{
    public class Weapon
    {
        public string Name;

        public string Creator;

        public int BulletAmmount;

        public Weapon(string name, string creator, int bulletAmmount)
        {
            Name = name;
            Creator = creator;
            BulletAmmount = bulletAmmount;
        }


        public void Shoot()
        {
            Console.WriteLine("one shot was fired");
            BulletAmmount -= 1;


        }



    }
}