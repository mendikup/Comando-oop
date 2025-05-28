

namespace Enemies.nodeles

{
    public class EnemyFactory
    {
        static List<string> airEnenmyNames = new List<string> { "drakon", "iron dom", "Evel", "badi", "cruli" };
        static List<string> seaEnemies = new List<string> { "Kraken", "Deeplurker", "Sirenmaw", "Wavefiend", "Coraljaw" };
        static List<string> fireEnemies = new List<string> { "Blazekin", "Infernoid", "Ashbeast", "Flametail", "Scorchborn" };

        public List<Enemy> enemiesList = new List<Enemy> { };





        public  void CreateEnemies(string type)
        {

            Random random = new Random();

            switch (type)
            {
                case "Air enemy":

                    for (int i = 0; i < 5; i++)
                    {
                        int index = random.Next(airEnenmyNames.Count);
                        string enemyName = airEnenmyNames[index];
                        AirEnemy airEnemy = new AirEnemy(enemyName);
                        enemiesList.Add(airEnemy);

                    }
                    break;


                case "Sea enemy":

                    for (int i = 0; i < 5; i++)


                    {
                        int index1 = random.Next(seaEnemies.Count);
                        string enemyName1 = seaEnemies[index1];
                        SeaEnemy SeaEnemy = new SeaEnemy(enemyName1);
                        enemiesList.Add(SeaEnemy);
                    }

                    break;

                case "fire enemy":

                    for (int i = 0; i < 5; i++)
                    {
                        int index2 = random.Next(fireEnemies.Count);
                        string enemyName2 = fireEnemies[index2];
                        FireEnemy SeaEnemy2 = new FireEnemy(enemyName2);
                        enemiesList.Add(SeaEnemy2);
                    }
                    break;

                default:
                    Console.WriteLine("can't craete such a type");
                    break;
            }














        }

    }





}


