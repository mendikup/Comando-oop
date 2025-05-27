using Commandos.models;

namespace Comando.models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AirCommando airCommando1 = new AirCommando("Air Commando soldier", "iron dom", "Attack");
            airCommando1.Fly();
       

        }
    }
}