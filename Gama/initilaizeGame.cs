using Enemies.nodeles;
using Comando.models;
using Commandos.models;

namespace Game.models
{
    public static class InitilaizeGame
    {


        public static void start()
        {
            List<Commando> commandoSoldiers = initilaizeCommandoFactory();





        }



        public static List<Commando> initilaizeCommandoFactory()
        {
            CommandoFactory commandoFactory = new CommandoFactory { };
            string[] commanduUnits = { "Sea commando", "Air commando " };
            for (int i = 0; i < commanduUnits.Length; i++)
            {
                commandoFactory.CreatecommandoUnit(commanduUnits[i]);


            }

            List<Commando> commandoSoldiers = commandoFactory.comandoSoldiersList;


            return commandoSoldiers;

        }



        public static List<Enemy> initilaizeEnemyFactory()
        {
            EnemyFactory enemyFactory = new EnemyFactory { };
            string[] enemyList = { "Sea enemy", "Air enemy ", "fire enemy" };
            for (int i = 0; i < enemyList.Length; i++)
            {
                enemyFactory.CreateEnemies(enemyList[i]);



            }

            List<Enemy> enemies = enemyFactory.enemiesList;

            return enemies;



        }

    }
}