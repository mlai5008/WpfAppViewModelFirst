using WpfAppViewModelFirst.Infrastructure.Interfaces.ViewModels;
using WpfAppViewModelFirst.Infrastructure.ViewModels.Base;

namespace WpfAppViewModelFirst.Customization.ViewModels
{
    public class BlackViewModel : BaseViewModel, IBlackViewModel
    {
        #region Fields
        private string _propA = "BlackViewModel with Customization";
        #endregion

        #region Ctor
        public BlackViewModel()
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