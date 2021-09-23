﻿using System;
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
    /// Логика взаимодействия для WindowDealPlace.xaml
    /// </summary>
    public partial class WindowDealPlace : Window
    {
        public WindowDealPlace()
        {
            InitializeComponent();
            DealPlaceViewModel vmDealPlace = new DealPlaceViewModel();
            lvDealPlace.ItemsSource = vmDealPlace.ListDealPlace;
        }
    }
}
