using WpfAppViewModelFirst.Infrastructure.Interfaces.ViewModels;
using WpfAppViewModelFirst.ViewModels.ViewModels.Base;

namespace WpfAppViewModelFirst.ViewModels.ViewModels
{
    public class WhiteViewModel : BaseViewModel, IWhiteViewModel
    {
        #region Fields
        private string _propA = "WhiteViewModel";
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