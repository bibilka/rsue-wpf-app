using System;
using System.Collections.ObjectModel;
using WpfApplication.Model;


namespace WpfApplication.ViewModel
{
    public class DealTypeViewModel
    {
        public ObservableCollection<DealType> ListDealType { get; set; } = new ObservableCollection<DealType>();
        public DealTypeViewModel()
        {
            this.ListDealType.Add(
                new DealType
                {
                    Id = 1,
                    Type = "брокерская"
                }
            );

            this.ListDealType.Add(
                new DealType
                {
                    Id = 2,
                    Type = "дилерская"
                }
            );

        }
    }
}
