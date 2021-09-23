using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApplication.Model
{
    /**
     * валюта
     */
    public class Currency
    {
        public int Id { get; set; }
        public string CurrencyFull { get; set; }
        public string CurrencyShort { get; set; }

        public Currency() { }
        public Currency(int Id, string CurrencyFull, string CurrencyShort)
        {
            this.Id = Id;
            this.CurrencyFull = CurrencyFull;
            this.CurrencyShort = CurrencyShort;
        }
    }

}
