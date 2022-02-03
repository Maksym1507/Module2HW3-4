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

        private ContainerBuilder Builder { get; set; }

        public IContainer RegisterTypes()
        {
            Builder.RegisterType<NotificationService>().As<INotificationService>();
            Builder.RegisterType<Starter>();
            return Builder.Build();
        }
    }
}
