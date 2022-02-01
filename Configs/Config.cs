using System;
using Autofac;
using Module2HW3_4.Interfaces;
using Module2HW3_4.Services;

namespace Module2HW3_4.Configs
{
    public class Config
    {
        public Config()
        {
            Builder = new ContainerBuilder();
        }

        private ContainerBuilder Builder { get; init; }

        public Starter BuildStarter()
        {
            Builder.RegisterType<NotificationService>().As<IShowMessage>();
            Builder.RegisterType<Starter>();
            var container = Builder.Build();
            return container.Resolve<Starter>();
        }
    }
}
