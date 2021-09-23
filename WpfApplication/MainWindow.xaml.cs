using System.Windows;
using WpfApplication.View;

namespace WpfApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Deal_OnClick(object sender, RoutedEventArgs e)
        {
            WindowDeal w = new WindowDeal();
            w.Show();
        }

        private void Currency_OnClick(object sender, RoutedEventArgs e)
        {
            WindowCurrency w = new WindowCurrency();
            w.Show();
        }

        private void DealType_OnClick(object sender, RoutedEventArgs e)
        {
            WindowDealType w = new WindowDealType();
            w.Show();
        }

        private void DealPlace_OnClick(object sender, RoutedEventArgs e)
        {
            WindowDealPlace w = new WindowDealPlace();
            w.Show();
        }
    }
}
