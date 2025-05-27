namespace Comando.models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Commando commandoSoldier1 = new Commando("meni", "thekiller", "walk");

            Console.WriteLine(commandoSoldier1.CodeName);
            commandoSoldier1.CodeName = "the iron men";
             Console.WriteLine(commandoSoldier1.CodeName);
        }
    }
}