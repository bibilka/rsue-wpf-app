using System.Windows;
using WpfApplication.Model;

namespace WpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для WindowNewDealPlace.xaml
    /// </summary>
    public partial class WindowNewDealPlace : Window
    {
        public WindowNewDealPlace()
        {
            InitializeComponent();
        }

        private void BtSave_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }

        
    }


}
