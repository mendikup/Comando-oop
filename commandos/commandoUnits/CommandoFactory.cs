

using Commandos.models;

namespace Enemies.nodeles

{
    public class CommandoFactory
    {
        static List<string> names = new List<string> { "David", "Sarah", "Mendy", "Rachel", "Daniel" };
        List<char> codeNames = new List<char> { 'a', 'b', 'c', 'd', 'h' };

        public List<Commando> comandoSoldiersList = new List<Commando> { };





        public void CreatecommandoUnit(string type)
        {

            Random random = new Random();

            switch (type)
            {
                case "Air commando":

                    for (int i = 0; i < 5; i++)
                    {
                        int index = random.Next(comandoSoldiersList.Count);
                        string name = names[index];
                        char codeName = codeNames[index];
                        AirCommando airCommando = new AirCommando(name,codeName,"alive");
                        comandoSoldiersList.Add(airCommando );

                    }
                    break;


                case "Sea commando":

                    for (int i = 0; i < 5; i++)


                    {
                        int index1 = random.Next(names.Count);
                        string name = names[index1];
                        char codeName = codeNames[index1];
                        SeaCommando SeaEnemy = new SeaCommando(name,codeName,"alive");
                        comandoSoldiersList.Add(SeaEnemy);
                    }

                    break;


                default:
                    Console.WriteLine("can't craete such a type");
                    break;
            }














        }

    }





}


