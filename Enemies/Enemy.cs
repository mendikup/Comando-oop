namespace Enemies.nodeles
{
    public abstract class Enemy
    {
        public string Name { get; set; }
        protected int Live = 100;
        protected string Status = "Alive";

        public Enemy(string neme)
        {
            Name = neme;


        }


        public abstract void Scream();
        
      

    }
}