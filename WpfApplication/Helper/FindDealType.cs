using System;
using System.Collections.Generic;
using System.Text;
using WpfApplication.Model;

namespace WpfApplication.Helper
{
    public class FindDealType
    {
        int id;
        public FindDealType(int id)
        {
            this.id = id;
        }
        public bool DealTypePredicate(DealType type)
        {
            return type.Id == id;
        }
    }
}
