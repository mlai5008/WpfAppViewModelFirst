using WpfAppViewModelFirst.Infrastructure.Interfaces.ViewModels;
using WpfAppViewModelFirst.Infrastructure.ViewModels.Base;

namespace WpfAppViewModelFirst.Customization.ViewModels
{
    public class WhiteViewModel : BaseViewModel, IWhiteViewModel
    {
        #region Fields
        private string _propA = "WhiteViewModel with Customization";
        #endregion

        #region Ctor
        public WhiteViewModel()
        { }
        #endregion

        #region Properties
        public string PropA
        {
            get => _propA;
            set
            {
                if (_propA != value)
                {
                    _propA = value;
                    OnPropertyChanged();
                }
            }
        }
        #endregion
    }
}