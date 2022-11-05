namespace App
{
    public class Bucket
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int Capacity { get; set; }

        public string Color { get; set; }

        public Bucket()
        {
            Name = "Wiadro";
            Description = "Ladne";
            Capacity = 10;
            Color = "Szary";
        }

        public void Repait(string color)
        {
            Color = color;
        }
    }
}