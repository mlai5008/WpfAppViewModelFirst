using System.Windows.Controls;
using WpfAppViewModelFirst.Infrastructure.Interfaces.Views;

namespace WpfAppViewModelFirst.Customization.Views
{
    /// <summary>
    /// Логика взаимодействия для BlackView.xaml
    /// </summary>
    public partial class BlackView : UserControl, IBlackView
    {
        #region Ctor
        public BlackView()
        {
            InitializeComponent();
        } 
        #endregion
    }
}
