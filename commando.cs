namespace Comando.models
{
    public class Commando
    {
        private string Name;
      public  string CodeName { get; set; }
        public List<string> Tools = new List<string> { "Hammer", "chisel", "rope", "bag", "water", "bottle" };

        public string Status;

        public Commando(string name, string codeName, string status)
        {
            Name = name;
            CodeName = codeName;
            Status = status;


        }


        public void Walk()
        {
            System.Console.WriteLine("the solder is walking");
            Status = "walk";

        }


        public void Hide()
        {
            System.Console.WriteLine("the soldier is hiding");
            Status = "hide";

        }


        public void Attack()
        {
            System.Console.WriteLine($"the soldier{CodeName} is attacking ");


        }

        public void SayName(string coomanderRank)
        {
            if (coomanderRank == "GENERAL")
            {
                Console.WriteLine($"the neame of the soldier is {Name}");

            }

            else if (coomanderRank == "COLONEL")
            {
                Console.WriteLine($"the neame of the soldier is {CodeName}");

            }

            else
            {
                Console.WriteLine("teh information is classiified");

            }




        }
    }
}