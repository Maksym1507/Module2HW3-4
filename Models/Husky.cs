using System;
using Module2HW3_4.Extensions;

namespace Module2HW3_4.Models
{
    public class Husky : Dog
    {
        public Husky(string name, int averageAge, double weigt, int quantityOfTeeth, string earShape, int numberOfTrips)
            : base(name, averageAge, weigt, quantityOfTeeth, earShape)
        {
            NumberOfTrips = numberOfTrips;
        }

        public int NumberOfTrips { get; set; }

        public override void DoBark()
        {
            Console.WriteLine("I can bark as husky");
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAverage age: {AverageAge}\nWeight: {Weight}\nQuantity of teeth: {QuantityOfTeeth}\nEar shape: {EarShape.Reverse()}\nNumber of trips: {NumberOfTrips}";
        }
    }
}
