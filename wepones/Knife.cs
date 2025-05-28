namespace weapons.models
{
    public class Knife
    {
        public string Name { get; private set; }
        public double Weight { get; private set; }
        public string Color { get; private set; }

        public string Status { get; private set; }

        public string Creator;

        public Knife(string name, double weight, string color, string status, string cretor)
        {
            Name = name;
            Weight = weight;
            

        }

    }

}