namespace Module2HW3_4.Models
{
    public class Animal
    {
        public Animal(string name, int averageAge, double weight)
        {
            Name = name;
            AverageAge = averageAge;
            Weight = weight;
        }

        public string Name { get; set; }

        public int AverageAge { get; set; }

        public double Weight { get; set; }
    }
}
