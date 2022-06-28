using Autofac;
using WpfAppViewModelFirst.Infrastructure.Interfaces.ViewModels;
using WpfAppViewModelFirst.ViewModels.ViewModels;

namespace WpfAppViewModelFirst.ViewModels
{
    public class ViewModelsModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainViewModel>().As<IMainViewModel>().SingleInstance();

            base.Load(builder);
        }
    }
}