﻿using System.Windows;
using WpfAppViewModelFirst.Infrastructure.Interfaces.Views;

namespace WpfAppViewModelFirst.Views.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IMainWindow
    {
        #region Methods
        public MainWindow()
        {
            InitializeComponent();
        } 
        #endregion
    }
}
