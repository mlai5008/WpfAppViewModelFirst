using Autofac;
using WpfAppViewModelFirst.Customization.ViewModels;
using WpfAppViewModelFirst.Customization.Views;
using WpfAppViewModelFirst.Infrastructure.Interfaces.ViewModels;
using WpfAppViewModelFirst.Infrastructure.Interfaces.Views;

namespace WpfAppViewModelFirst.Customization
{
    public class CustomizationModule : Module
    {
        #region Methods
        protected override void Load(ContainerBuilder builder)
        {
            RegisterViewTypes(builder);
            RegisterViewModelTypes(builder);

            base.Load(builder);
        }

        private void RegisterViewTypes(ContainerBuilder builder)
        {
            builder.RegisterType<BlackView>().As<IBlackView>().SingleInstance();
            builder.RegisterType<WhiteView>().As<IWhiteView>().SingleInstance();
        }

        private void RegisterViewModelTypes(ContainerBuilder builder)
        {
            builder.RegisterType<BlackViewModel>().As<IBlackViewModel>().SingleInstance();
            builder.RegisterType<WhiteViewModel>().As<IWhiteViewModel>().SingleInstance();
        }

        #endregion
    }
}