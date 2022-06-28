using Autofac;
using WpfAppViewModelFirst.Infrastructure.Interfaces.Views;
using WpfAppViewModelFirst.Views.Views;

namespace WpfAppViewModelFirst.Views
{
    public class ViewsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainWindow>().As<IMainWindow>().SingleInstance();

            base.Load(builder);
        }
    }
}