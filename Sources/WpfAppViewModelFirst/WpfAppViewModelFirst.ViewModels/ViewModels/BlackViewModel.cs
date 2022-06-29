using WpfAppViewModelFirst.Infrastructure.Interfaces.ViewModels;
using WpfAppViewModelFirst.ViewModels.ViewModels.Base;

namespace WpfAppViewModelFirst.ViewModels.ViewModels
{
    public class BlackViewModel : BaseViewModel, IBlackViewModel
    {
        #region Fields
        private string _propA = "BlackViewModel";
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