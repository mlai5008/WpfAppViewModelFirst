using Autofac;
using System.Reflection;

namespace WpfAppViewModelFirst.Startup
{
    public class Bootstrapper
    {
        #region Consts
        private const string ViewModelsAssembly = "WpfAppViewModelFirst.ViewModels.dll";
        private const string ViewsAssembly = "WpfAppViewModelFirst.Views.dll";
        #endregion

        #region Methods
        public IContainer Bootstrap()
        {
            ContainerBuilder builder = new ContainerBuilder();

            RegisterAssemblyModules(builder);
            return builder.Build();
        }

        private void RegisterAssemblyModules(ContainerBuilder builder)
        {
            foreach (string assembly in new string[]{ ViewsAssembly, ViewModelsAssembly })
            {
                builder.RegisterAssemblyModules(Assembly.LoadFrom(assembly));
            }
        } 
        #endregion
    }
}