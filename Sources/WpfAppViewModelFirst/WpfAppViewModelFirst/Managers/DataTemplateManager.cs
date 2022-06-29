using System;
using System.Windows;
using System.Windows.Markup;

namespace WpfAppViewModelFirst.Managers
{
    public class DataTemplateManager
    {
        #region Methods
        public void RegisterDataTemplate<TView>(Type viewModelType, TView view)
        {
            if (view is FrameworkElement)
            {
                RegisterDataTemplate(viewModelType, view.GetType());
            }
            else
                throw new InvalidCastException();
        }

        private void RegisterDataTemplate(Type viewModelType, Type viewType)
        {
            DataTemplate template = CreateTemplate(viewModelType, viewType);

            object key = template.DataTemplateKey;
            Application.Current.Resources.Add(key, template);
        }

        private DataTemplate CreateTemplate(Type viewModelType, Type viewType)
        {
            const string xamlTemplate = "<DataTemplate DataType=\"{{x:Type vm:{0}}}\"><v:{1} /></DataTemplate>";
            var xaml = String.Format(xamlTemplate, viewModelType.Name, viewType.Name, viewModelType.Namespace, viewType.Namespace);

            var context = new ParserContext();

            context.XamlTypeMapper = new XamlTypeMapper(new string[0]);
            context.XamlTypeMapper.AddMappingProcessingInstruction("vm", viewModelType.Namespace, viewModelType.Assembly.FullName);
            context.XamlTypeMapper.AddMappingProcessingInstruction("v", viewType.Namespace, viewType.Assembly.FullName);

            context.XmlnsDictionary.Add("", "http://schemas.microsoft.com/winfx/2006/xaml/presentation");
            context.XmlnsDictionary.Add("x", "http://schemas.microsoft.com/winfx/2006/xaml");
            context.XmlnsDictionary.Add("vm", "vm");
            context.XmlnsDictionary.Add("v", "v");

            var template = (DataTemplate)XamlReader.Parse(xaml, context);
            return template;
        } 
        #endregion
    }
}