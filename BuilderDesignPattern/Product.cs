

namespace BuilderDesignPattern
{ 
    public class House
    {
        public string Walls { get; set; }
        public string Roof { get; set; }
        public string Doors { get; set; }
        public string Windows { get; set; }

        public override string ToString()
        {
            return $"House with {Walls}, {Roof}, {Doors}, and {Windows}.";
        }
    }
}

