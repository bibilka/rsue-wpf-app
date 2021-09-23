using System;
using System.Collections.ObjectModel;
using WpfApplication.Model;

namespace WpfApplication.ViewModel
{
    public class DealViewModel
    {
        public ObservableCollection<Deal> ListDeal { get; set; } = new ObservableCollection<Deal>();
        public DealViewModel()
        {
            this.ListDeal.Add(
                new Deal
                {
                    Id = 1,
                    TypeId = 1,
                    PlaceId = 3,
                    CurrencyId = 2,
                    Number = 32423,
                    Tiker = "AMZN",
                    Order = "AB23444",
                    Quantity = 5,
                    Price = 15232.4,
                    TotalCost = 20001.543,
                    Trader = "TR124",
                    Commission = 15
                }
            );

            this.ListDeal.Add(
                new Deal
                {
                    Id = 2,
                    TypeId = 1,
                    PlaceId = 1,
                    CurrencyId = 2,
                    Number = 43545,
                    Tiker = "BUD",
                    Order = "CD3444",
                    Quantity = 25,
                    Price = 3232.4,
                    TotalCost = 4001.543,
                    Trader = "TR1434",
                    Commission = 12
                }
            );

            this.ListDeal.Add(
                new Deal
                {
                    Id = 3,
                    TypeId = 2,
                    PlaceId = 3,
                    CurrencyId = 1,
                    Number = 56456,
                    Tiker = "AMZN",
                    Order = "DSF222",
                    Quantity = 1,
                    Price = 15555.324,
                    TotalCost = 122222.33,
                    Trader = "TR7664",
                    Commission = 15
                }
            );

            this.ListDeal.Add(
                new Deal
                {
                    Id = 4,
                    TypeId = 1,
                    PlaceId = 2,
                    CurrencyId = 2,
                    Number = 21333,
                    Tiker = "AAPLE",
                    Order = "HGD333",
                    Quantity = 4,
                    Price = 13455.314,
                    TotalCost = 15455.314,
                    Trader = "TR4564",
                    Commission = 10
                }
            );

            this.ListDeal.Add(
                new Deal
                {
                    Id = 5,
                    TypeId = 2,
                    PlaceId = 4,
                    CurrencyId = 3,
                    Number = 65454,
                    Tiker = "SBER",
                    Order = "ASSS4444",
                    Quantity = 5,
                    Price = 2333.54,
                    TotalCost = 2733.54,
                    Trader = "TR888",
                    Commission = 5
                }
            );

        }
    }
}
