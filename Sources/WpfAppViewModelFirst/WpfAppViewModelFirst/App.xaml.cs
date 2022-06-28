﻿using Autofac;
using System.Windows;
using WpfAppViewModelFirst.Infrastructure.Interfaces.ViewModels;
using WpfAppViewModelFirst.Infrastructure.Interfaces.Views;
using WpfAppViewModelFirst.Startup;

namespace WpfAppViewModelFirst
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Bootstrapper bootstrapper = new Bootstrapper();
            IContainer container = bootstrapper.Bootstrap();

            IMainWindow mainWindow = container.Resolve<IMainWindow>();
            mainWindow.DataContext = container.Resolve<IMainViewModel>();
            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}