using System;
using System.Collections.ObjectModel;
using WpfApplication.Model;


namespace WpfApplication.ViewModel
{
    public class CurrencyViewModel
    {
        public ObservableCollection<Currency> ListCurrency { get; set; } = new ObservableCollection<Currency>();
        public CurrencyViewModel()
        {
            this.ListCurrency.Add(
                new Currency {
                    Id = 1,
                    CurrencyFull = "Российский рубль",
                    CurrencyShort = "RUB"
                }
            );

            this.ListCurrency.Add(
                new Currency
                {
                    Id = 2,
                    CurrencyFull = "Доллар США",
                    CurrencyShort = "USD"
                }
            );

            this.ListCurrency.Add(
                new Currency
                {
                    Id = 3,
                    CurrencyFull = "Евро",
                    CurrencyShort = "EUR"
                }
            );

        }
    }
}
