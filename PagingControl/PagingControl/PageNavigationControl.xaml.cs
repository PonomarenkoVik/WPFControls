using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PagingControl
{
    /// <summary>
    /// Interaction logic for PageNavigationControl.xaml
    /// </summary>
    public partial class PageNavigationControl : UserControl, INotifyPropertyChanged
    {
        public PageNavigationControl()
        {
            DataContext = this;
            InitializeComponent();
            BackButtonText = "Back";
            NextButtonText = "Next";
            OnBoardingButtonTextDefaultBrush = Brushes.White;
            OnBoardingBackDefaultBrush = Brushes.Gray;
            OnBoardingButtonTextHoverBrush = Brushes.Black;
            OnBoardingButtonBackHoverBrush = Brushes.White;
            PointItems = new bool[]{ false, false, true};
            SetPageNumber(1, 6);
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private string _backButtonText;
        public string BackButtonText
        {
            get => _backButtonText;
            set
            {
                _backButtonText = value;
                OnPropertyChanged();
            }
        }

        private string _nextButtonText;
        public string NextButtonText
        {
            get => _nextButtonText;
            set
            {
                _nextButtonText = value;
                OnPropertyChanged();
            }
        }

        private string _pageNumber;
        public string PageNumber
        {
            get => _pageNumber;
            set
            {
                _pageNumber = value;
                OnPropertyChanged();
            }
        }

        private Brush _onBoardingButtonTextDefaultBrush;
        public Brush OnBoardingButtonTextDefaultBrush
        {
            get => _onBoardingButtonTextDefaultBrush;
            set
            {
                _onBoardingButtonTextDefaultBrush = value;
                OnPropertyChanged();
            }
        }

        private Brush _onBoardingBackDefaultBrush;
        public Brush OnBoardingBackDefaultBrush
        {
            get => _onBoardingBackDefaultBrush;
            set
            {
                _onBoardingBackDefaultBrush = value;
                OnPropertyChanged();
            }
        }

        private Brush _onBoardingButtonTextHoverBrush;
        public Brush OnBoardingButtonTextHoverBrush
        {
            get => _onBoardingButtonTextHoverBrush;
            set
            {
                _onBoardingButtonTextHoverBrush = value;
                OnPropertyChanged();
            }
        }

        private Brush _onBoardingButtonBackHoverBrush;
        public Brush OnBoardingButtonBackHoverBrush
        {
            get => _onBoardingButtonBackHoverBrush;
            set
            {
                _onBoardingButtonBackHoverBrush = value;
                OnPropertyChanged();
            }
        }




        public bool[] PointItems
        {
            get { return (bool[])GetValue(MyPropertyProperty); }
            set { SetValue(MyPropertyProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyPropertyProperty =
            DependencyProperty.Register("MyProperty", typeof(bool[]), typeof(PageNavigationControl));


        public void SetPageNumber(int number, int from)
        {
            PageNumber = $"{number}/{from}";
        }
        


        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
