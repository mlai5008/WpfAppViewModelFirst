using WpfAppViewModelFirst.Infrastructure.Interfaces.ViewModels;
using WpfAppViewModelFirst.ViewModels.ViewModels.Base;

namespace WpfAppViewModelFirst.ViewModels.ViewModels
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        #region Fields
        private IBlackViewModel _blackViewModel;
        private IWhiteViewModel _whiteViewModel;
        #endregion

        #region Ctor
        public MainViewModel(IBlackViewModel blackViewModel, IWhiteViewModel whiteViewModel)
        {
            _blackViewModel = blackViewModel;
            _whiteViewModel = whiteViewModel;
        }
        #endregion

        #region Properties
        public IBlackViewModel BlackViewModel
        {
            get => _blackViewModel;
            set
            {
                _blackViewModel = value;
                OnPropertyChanged();
            }
        }

        public IWhiteViewModel WhiteViewModel
        {
            get => _whiteViewModel;
            set
            {
                _whiteViewModel = value;
                OnPropertyChanged();
            }
        }
        #endregion
    }
}