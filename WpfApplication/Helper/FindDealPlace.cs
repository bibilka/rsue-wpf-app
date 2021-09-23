using System;
using System.Collections.Generic;
using System.Text;
using WpfApplication.Model;

namespace WpfApplication.Helper
{
    public class FindDealPlace
    {
        int id;
        public FindDealPlace(int id)
        {
            this.id = id;
        }
        public bool DealPlacePredicate(DealPlace place)
        {
            return place.Id == id;
        }
    }
}
