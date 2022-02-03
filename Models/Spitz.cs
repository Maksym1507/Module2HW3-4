using System;
using Module2HW3_4.Extensions;

namespace Module2HW3_4.Models
{
    public class Spitz : Dog
    {
        public Spitz(string name, int averageAge, double weigt, int quantityOfTeeth, string earShape, int aggressiveness)
            : base(name, averageAge, weigt, quantityOfTeeth, earShape)
        {
            Aggressiveness = aggressiveness;
        }

        public int Aggressiveness { get; set; }

        public override void DoBark()
        {
            Console.WriteLine("I can bark as spitz");
        }

        public override string ToString()
        {
            return $"Name: {Name.Reverse()}\nAverage age: {AverageAge}\nWeight: {Weight}\nQuantity of teeth: {QuantityOfTeeth}\nEar shape: {EarShape}\nAggressiveness: {Aggressiveness}%";
        }
    }
}
