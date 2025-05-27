namespace Enemies.nodeles
{
    public class ArmedEnemy : Enemy
    {
        bool Armed;
        public ArmedEnemy(string neme, int live, string status, bool armed) : base(neme, live, status)
        {
            Armed = armed;

        }


    }


}