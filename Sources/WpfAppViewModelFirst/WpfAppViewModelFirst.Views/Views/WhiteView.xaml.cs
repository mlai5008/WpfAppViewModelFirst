using System.Windows.Controls;
using WpfAppViewModelFirst.Infrastructure.Interfaces.Views;

namespace WpfAppViewModelFirst.Views.Views
{
    /// <summary>
    /// Логика взаимодействия для WhiteView.xaml
    /// </summary>
    public partial class WhiteView : UserControl, IWhiteView
    {
        #region Ctor
        public WhiteView()
        {
            InitializeComponent();
        } 
        #endregion
    }
}
