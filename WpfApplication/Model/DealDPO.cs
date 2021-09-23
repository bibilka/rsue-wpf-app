using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApplication.Model
{
    /**
     * Сделка
     */
    public class DealDPO
    {
        public int Id { get; set; }
        public string Place { get; set; } // место
        public string Currency { get; set; } // валюта
        public string Type { get; set; } // тип сделки

        public int Number { get; set; } // номер

        // тикер ценной бумаги
        public string Tiker { get; set; }

        // номер поручения по сделке
        public string Order { get; set; }

        // количество ценных бумаг
        public int Quantity { get; set; }

        // цена по сделке
        public double Price { get; set; }

        // общая сумма сделки
        public double TotalCost { get; set; }

        // код трейдера
        public string Trader { get; set; }

        // комиссия торговой площадки
        public double Commission { get; set; }

        public DealDPO() { }
        public DealDPO(int Id, string Type, string Place, string Currency, int Number, string Tiker, string Order, int Quantity, double Price, double TotalCost, string Trader, double Commission)
        {
            this.Id = Id;
            this.Type = Type;
            this.Place = Place;
            this.Currency = Currency;
            this.Number = Number;
            this.Tiker = Tiker;
            this.Order = Order;
            this.Quantity = Quantity;
            this.Price = Price;
            this.TotalCost = TotalCost;
            this.Trader = Trader;
            this.Commission = Commission;
        }
    }
}
