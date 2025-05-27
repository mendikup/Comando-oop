namespace Commandos.models
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName, string status) : base(name, codeName, status) { }


        public void Swim()
        {
            Console.WriteLine("SeaCommando can swim");

        }



    }
}