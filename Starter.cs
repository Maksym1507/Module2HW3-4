using Module2HW3_4.Extensions;
using Module2HW3_4.Interfaces;
using Module2HW3_4.Models;

namespace Module2HW3_4
{
    public class Starter
    {
        public Starter(INotificationService message)
        {
            Message = message;
        }

        private INotificationService Message { get; set; }

        public void Run()
        {
            var husky = new Husky("Tobi", 123, 67.7, 18, "Round", 12);
            var spitz = new Spitz("Rex", 200, 677, 18, "Oval", 100);

            Dog[] dogs = { spitz, husky };
            var dog = ArrayExtention.SearchByAverageAge(dogs);

            Message.ShowMessage("Enter dog which has the biggest averrage age:");

            Message.ShowMessage(dog.ToString());

            dog.DoBark();
        }
    }
}
