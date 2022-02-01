using Module2HW3_4.Configs;

namespace Module2HW3_4
{
    internal class Program
    {
        private static void Main()
        {
            var config = new Config();
            var start = config.BuildStarter();
            start.Run();
        }
    }
}
