
using System.Windows;
using WpfApplication.ViewModel;
using WpfApplication.Model;

namespace WpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для WindowDealPlace.xaml
    /// </summary>
    public partial class WindowDealPlace : Window
    {
        DealPlaceViewModel vmDealPlace;

        public WindowDealPlace()
        {
            InitializeComponent();
            this.vmDealPlace = new DealPlaceViewModel();
            lvDealPlace.ItemsSource = vmDealPlace.ListDealPlace;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            WindowNewDealPlace wnDealPlace = new WindowNewDealPlace
            {
                Title = "Новое место сделки",
                Owner = this
            };

            // формирование кода нового объекта
            int maxIdDealPlace = this.vmDealPlace.MaxId() + 1;
            DealPlace dealPlace = new DealPlace
            {
                Id = maxIdDealPlace
            };

            wnDealPlace.DataContext = dealPlace;

            if (wnDealPlace.ShowDialog() == true)
            {
                vmDealPlace.ListDealPlace.Add(dealPlace);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            WindowNewDealPlace wnDealPlace = new WindowNewDealPlace
            {
                Title = "Редактирование места сделки",
                Owner = this
            };
            DealPlace dealPlace = lvDealPlace.SelectedItem as DealPlace;
            if (dealPlace != null)
            {
                DealPlace tempDealPlace = dealPlace.ShallowCopy();
                wnDealPlace.DataContext = tempDealPlace;
                if (wnDealPlace.ShowDialog() == true)
                {
                    // сохранение данных
                    dealPlace.PlaceShort = tempDealPlace.PlaceShort;
                    dealPlace.PlaceFull = tempDealPlace.PlaceFull;

                    lvDealPlace.ItemsSource = null;
                    lvDealPlace.ItemsSource = vmDealPlace.ListDealPlace;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать место для редактированния",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            DealPlace dealPlace = (DealPlace)lvDealPlace.SelectedItem;
            if (dealPlace != null)
            {
                MessageBoxResult result = MessageBox.Show("Удалить данные по месту: " + dealPlace.PlaceShort, "Предупреждение", MessageBoxButton.OKCancel, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    vmDealPlace.ListDealPlace.Remove(dealPlace);
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать место для удаления",
                "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }


    }
}
