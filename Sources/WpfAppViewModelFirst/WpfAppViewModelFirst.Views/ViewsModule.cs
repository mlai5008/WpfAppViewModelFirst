using Autofac;
using WpfAppViewModelFirst.Infrastructure.Interfaces.Views;
using WpfAppViewModelFirst.Views.Views;

namespace WpfAppViewModelFirst.Views
{
    public class ViewsModule : Module
    {
        #region Methods
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainWindow>().As<IMainWindow>().SingleInstance();
            builder.RegisterType<BlackView>().As<IBlackView>().SingleInstance();
            builder.RegisterType<WhiteView>().As<IWhiteView>().SingleInstance();

            base.Load(builder);
        } 
        #endregion
    }
}