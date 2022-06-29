using System.Windows.Controls;
using WpfAppViewModelFirst.Infrastructure.Interfaces.Views;

namespace WpfAppViewModelFirst.Views.Views
{
    /// <summary>
    /// Логика взаимодействия для BlackView.xaml
    /// </summary>
    public partial class BlackView : UserControl, IBlackView
    {
        #region Methods
        public BlackView()
        {
            InitializeComponent();
        }
    } 
    #endregion
}
