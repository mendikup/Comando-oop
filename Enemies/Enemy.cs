namespace Enemies.nodeles
{
    public class Enemy
    {
        string Name;
        int Live;
        string Status;

        public Enemy(string neme, int live, string status)
        {
            Name = neme;

            Live = live;

            Status = status;

        }


        public void Scream()
        {
            Console.WriteLine("i am an Enemyyyyy!!!!!!")
        }

    }
}