using Autofac;
using WpfAppViewModelFirst.Infrastructure.Interfaces.ViewModels;
using WpfAppViewModelFirst.ViewModels.ViewModels;

namespace WpfAppViewModelFirst.ViewModels
{
    public class ViewModelsModule : Module
    {
        #region Methods
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainViewModel>().As<IMainViewModel>().SingleInstance();
            builder.RegisterType<BlackViewModel>().As<IBlackViewModel>().SingleInstance();
            builder.RegisterType<WhiteViewModel>().As<IWhiteViewModel>().SingleInstance();

            base.Load(builder);
        } 
        #endregion
    }
}