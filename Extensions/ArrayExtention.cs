using Module2HW3_4.Models;

namespace Module2HW3_4.Extensions
{
    public static class ArrayExtention
    {
        public static Dog SearchByAverageAge(this Dog[] dogs)
        {
            var dog = dogs[0];

            for (int i = 0; i < dogs.Length; i++)
            {
                if (dogs[i].AverageAge > dog.AverageAge)
                {
                    dog = dogs[i];
                }
            }

            return dog;
        }
    }
}
