namespace WpfAppViewModelFirst.Infrastructure.Interfaces.Views
{
    public interface IMainWindow
    {
        #region Properties
        public object DataContext { get; set; }
        #endregion

        #region Methods
        public void Show(); 
        #endregion
    }
}