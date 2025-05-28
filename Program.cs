using Commandos.models;
using Enemies.nodeles;

namespace Comando.models
{
    public class Program
    {
        public static void Main(string[] args)
        {

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


            CommandoFactory commandoFactory = new CommandoFactory ();
            string[] commanduUnits = { "Sea commando", "Air commando " };
            for (int i = 0; i < commanduUnits.Length; i++)
            {
                commandoFactory.CreatecommandoUnit(commanduUnits[i]);



            }

            List<Commando> commendosoldiers = commandoFactory.comandoSoldiersList;
            Console.WriteLine(commendosoldiers.Count);
            foreach (var cs in commendosoldiers)
            {
                cs.Attack();
            }


        }
    }
}