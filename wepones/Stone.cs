namespace weapons.models
{
    public class Stone
    {
        public string Name { get; private set; }
        public string MetalType { get; private set; }
        public string Manufacturer { get; private set; }
        public string Color { get; private set; }
        public double Weight { get; private set; }

        public string Status { get; private set; }
        public int MaxHits { get; private set; }
        public int CurrentHits { get; private set; }
    }

    
}