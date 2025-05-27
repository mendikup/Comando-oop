namespace Enemies.nodeles
{
    public class ArmedEnemy : Eneemy
    {
        bool Armed;
        public ArmedEnemy(string neme, int live, string status, bool armed) : base(neme, live, status)
        {
            Armed = armed;

        }


    }


}