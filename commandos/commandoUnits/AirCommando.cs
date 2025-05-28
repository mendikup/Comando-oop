using System.Security.Cryptography.X509Certificates;

namespace Commandos.models
{
    public class AirCommando : Commando
    {
        public AirCommando(string name, char codeName, string status) : base(name, codeName, status) { }





        public override void Attack()
        {
            Console.WriteLine($"the AirCommando soldier {CodeName} is attacking ");


        }



        public void Fly()
        {
            Console.WriteLine("AirCommando can parachut");

        }



    }
}