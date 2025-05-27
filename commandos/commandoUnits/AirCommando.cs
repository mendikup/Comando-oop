using System.Security.Cryptography.X509Certificates;

namespace Commandos.models
{
    public class AirCommando : Commando
    {
        public AirCommando(string name, string codeName, string status) : base(name, codeName, status) { }






        public void Fly()
        {
            Console.WriteLine("AirCommando can parachut");

        }



    }
}