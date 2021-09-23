using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WpfApplication.ViewModel;

namespace WpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для WindowDealType.xaml
    /// </summary>
    public partial class WindowDealType : Window
    {
        public WindowDealType()
        {
            InitializeComponent();
            DealTypeViewModel vm = new DealTypeViewModel();
            lvDealType.ItemsSource = vm.ListDealType;
        }
    }
}
