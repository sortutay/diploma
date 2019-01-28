using DpVisual.ViewModels;
using GeneratingFunctions.Definition;
using System.Windows;

namespace DpVisual.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;

        public MainWindow()
        {
            _viewModel = new MainViewModel();
            DataContext = _viewModel;
            InitializeComponent();
        }

        private void FirstGenBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.FirstGen = new GenFunc1(_viewModel.FirstFinalExp, _viewModel.FirstCoefParam);
        }

        private void SecondGenBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SecondGen = new GenFunc2(_viewModel.SecondFinalExp, _viewModel.SecondExpParam);
        }

        private void ThirdGenBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.ThirdGen = new GenFunc3(_viewModel.ThirdFinalExp);
        }

        private void FourthGenBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.FourthGen = new GenFunc4(_viewModel.FourthCoefParam);
        }

        private void FifthGenBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.FifthGen = new GenFunc5(_viewModel.FifthFinalExp);
        }

        private void SixthGenBtn_OnClick(object sender, RoutedEventArgs e)
        {
            _viewModel.SixthGen = new GenFunc6(_viewModel.SixthFinalExp);
        }
    }
}