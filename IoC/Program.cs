using System;
using Autofac;
using IoC.Entitites;
using IoC.Outs;
using IoC.Repo;

namespace IoC
{
    class Program
    {
        public static IContainer Container { get; set; }

        static void Main(string[] args)
        {
            CreateAutofacContainer();

            var repo = Container.Resolve<RepoDateTime>();
            repo.Show();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        private static void CreateAutofacContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<TextOut>().As<IOut>();
            builder.RegisterAssemblyTypes(typeof(IRepo).Assembly).AsSelf().As<IRepo>();
            builder.RegisterAssemblyTypes(typeof(IObj).Assembly).AsSelf().As<IObj>();
            builder.RegisterGeneric(typeof(Repo<>)).AsSelf().As(typeof(IRepo<>));

            Container = builder.Build();
        }
    }
}
