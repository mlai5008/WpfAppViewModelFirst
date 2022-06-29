using WpfAppViewModelFirst.Infrastructure.Interfaces.ViewModels;
using WpfAppViewModelFirst.ViewModels.ViewModels.Base;

namespace WpfAppViewModelFirst.ViewModels.ViewModels
{
    public class MainViewModel : BaseViewModel, IMainViewModel
    {
        #region Fields
        private IBlackViewModel _blackViewModel;
        #endregion

        #region Ctor
        public MainViewModel(IBlackViewModel blackViewModel)
        {
            _blackViewModel = blackViewModel;
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
        #endregion
    }
}