using System.Windows;
using WpfApplication.Helper;
using WpfApplication.ViewModel;
using WpfApplication.Model;
using System.Collections.Generic;
using System;
using System.Collections.ObjectModel;

namespace WpfApplication.View
{
    /// <summary>
    /// Логика взаимодействия для WindowDeal.xaml
    /// </summary>
    public partial class WindowDeal : Window
    {
        public WindowDeal()
        {
            InitializeComponent();

            DealViewModel vmDeal = new DealViewModel();

            CurrencyViewModel vmCurrency = new CurrencyViewModel();
            List<Currency> currencies = new List<Currency>();
            foreach (Currency curr in vmCurrency.ListCurrency)
            {
                currencies.Add(curr);
            }

            DealTypeViewModel vmDealType = new DealTypeViewModel();
            List<DealType> dealTypes = new List<DealType>();
            foreach (DealType type in vmDealType.ListDealType)
            {
                dealTypes.Add(type);
            }

            DealPlaceViewModel vmDealPlace = new DealPlaceViewModel();
            List<DealPlace> dealPlaces = new List<DealPlace>();
            foreach (DealPlace place in vmDealPlace.ListDealPlace)
            {
                dealPlaces.Add(place);
            }

            ObservableCollection<DealDPO> deals = new ObservableCollection<DealDPO>();
            
            FindCurrency currencyFinder;
            FindDealPlace dealPlaceFinder;
            FindDealType dealTypeFinder;

            foreach (var d in vmDeal.ListDeal)
            {
                currencyFinder = new FindCurrency(d.CurrencyId);
                Currency curr = currencies.Find(
                    new Predicate<Currency>(currencyFinder.CurrencyPredicate)
                );

                dealTypeFinder = new FindDealType(d.TypeId);
                DealType type = dealTypes.Find(
                    new Predicate<DealType>(dealTypeFinder.DealTypePredicate)
                );

                dealPlaceFinder = new FindDealPlace(d.PlaceId);
                DealPlace place = dealPlaces.Find(
                    new Predicate<DealPlace>(dealPlaceFinder.DealPlacePredicate)
                );

                deals.Add(new DealDPO
                {
                    Id = d.Id,
                    Type = type.Type,
                    Place = place.PlaceShort,
                    Currency = curr.CurrencyShort,
                    Number = d.Number,
                    Tiker = d.Tiker,
                    Order = d.Order,
                    Quantity = d.Quantity,
                    Price = d.Price,
                    TotalCost = d.TotalCost,
                    Trader = d.Trader,
                    Commission = d.Commission
                });
            }

            lvDeal.ItemsSource = deals;

        }
    }
}
