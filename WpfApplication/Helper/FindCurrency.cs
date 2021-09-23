using System;
using System.Collections.Generic;
using System.Text;
using WpfApplication.Model;

namespace WpfApplication.Helper
{
    public class FindCurrency
    {
        int id;
        public FindCurrency(int id)
        {
            this.id = id;
        }
        public bool CurrencyPredicate(Currency currency)
        {
            return currency.Id == id;
        }
    }
}
