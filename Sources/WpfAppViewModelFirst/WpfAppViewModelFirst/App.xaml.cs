using Autofac;
using System.Windows;
using WpfAppViewModelFirst.Infrastructure.Interfaces.ViewModels;
using WpfAppViewModelFirst.Infrastructure.Interfaces.Views;
using WpfAppViewModelFirst.Managers;
using WpfAppViewModelFirst.Startup;

namespace WpfAppViewModelFirst
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        #region Methods
        protected override void OnStartup(StartupEventArgs e)
        {
            Bootstrapper bootstrapper = new Bootstrapper();
            IContainer container = bootstrapper.Bootstrap();

            DataTemplateManager dataTemplateManager = new DataTemplateManager();
            dataTemplateManager.RegisterDataTemplate(typeof(IBlackViewModel), container.Resolve<IBlackView>());
            dataTemplateManager.RegisterDataTemplate(typeof(IWhiteViewModel), container.Resolve<IWhiteView>());


            IMainWindow mainWindow = container.Resolve<IMainWindow>();
            mainWindow.DataContext = container.Resolve<IMainViewModel>();
            mainWindow.Show();

            base.OnStartup(e);
        } 
        #endregion
    }
}