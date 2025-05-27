namespace Comando.models
{
    public class Commando
    {
        public string Name;
        public string CodeName;
        public List<string> Tools;

        public string Status;

        public Commando(string name, string codeName, string status)
        {
            Name = name;
            CodeName = codeName;
            Tools = new List<string>();
            Status = status;


        }


        void Walk()
        {
            System.Console.WriteLine("the solder is walking");
            Status = "walk";

        }


        void Hide()
        {
            System.Console.WriteLine("the soldier is hiding");
            Status = "hide";

        }
        

           void Attack()
        {
            System.Console.WriteLine($"the soldier{CodeName} is attacking ");
            

        }
    }
}