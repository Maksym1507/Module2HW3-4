using Module2HW3_4.Configs;
using Autofac;

namespace Module2HW3_4
{
    internal class Program
    {
        private static void Main()
        {
            var config = new Config();
            var container = config.RegisterTypes();
            var start = container.Resolve<Starter>();
            start.Run();
        }
    }
}
