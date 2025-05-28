using Commandos.models;
using Enemies.nodeles;
using Game.models;

namespace Comando.models
{
    public class Program
    {
        public static void Main(string[] args)
        {




            List<Commando> commandoSoldiers = InitilaizeGame.initilaizeCommandoFactory();



            List<Enemy> enemiesList = InitilaizeGame.initilaizeEnemyFactory();


            // AirCommando airCommando1 = new AirCommando("Air Commando soldier", "iron dom", "Attack");
            // SeaCommando seaCommando1 = new SeaCommando("Sea Commando soldier", "iron bee-", "hide");
            // Commando commando = new Commando("daniel fisher ", "the strongest", "hide");


            // Commando[] comandoSoldiers = new Commando[3];

            // comandoSoldiers[0] = airCommando1;
            // comandoSoldiers[1] = seaCommando1;
            // comandoSoldiers[2] = commando;

            // foreach (Commando soldier in comandoSoldiers)
            // {
            //     soldier.Attack();
            // }

            // List<Enemy> enemies = EnemyFactory.CreateEnemies();
            // enemies[0].Scream();
            // Console.WriteLine(enemies[3].Name);





            // Console.WriteLine(commendosoldiers.Count);
            // foreach (var cs in commendosoldiers)
            // {
            //     cs.Attack();
            // }


        }
    }
}