namespace Commandos.models
{
    public class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName, string status) : base(name, codeName, status) { }


           public override void Attack()
        {
            Console.WriteLine($"the SeaCommando soldier {CodeName} is attacking ");


        }


        public void Swim()
        {
            Console.WriteLine("SeaCommando can swim");

        }



    }
}