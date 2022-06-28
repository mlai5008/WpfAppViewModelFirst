using Autofac;

namespace WpfAppViewModelFirst.Startup
{
    public class Bootstrapper
    {
        #region Consts
        private const string ViewModelsAssembly = "WpfAppUseDataTemplateWithOutDataContext.ViewModels.dll";
        private const string ViewsAssembly = "WpfAppUseDataTemplateWithOutDataContext.Views.dll";
        #endregion

        #region Methods
        public IContainer Bootstrap()
        {
            ContainerBuilder builder = new ContainerBuilder();

            // Работает
            //builder.RegisterModule(new ViewModelsModule());

            // Работает
            //******************************************
            //builder.RegisterAssemblyModules(Assembly.LoadFrom("WpfAppWithOutDataContext.ViewModels.dll"));
            //**************************************

            //RegisterWindows(builder);
            //RegisterViewModels(builder);
            RegisterAssemblyModules(builder);
            return builder.Build();
        }

        private void RegisterAssemblyModules(ContainerBuilder builder)
        {

        } 
        #endregion
    }
}