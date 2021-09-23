using System;
using System.Collections.ObjectModel;
using WpfApplication.Model;

namespace WpfApplication.ViewModel
{
    public class DealPlaceViewModel
    {
        public ObservableCollection<DealPlace> ListDealPlace { get; set; } = new ObservableCollection<DealPlace>();
        public DealPlaceViewModel()
        {
            this.ListDealPlace.Add(
                new DealPlace
                {
                    Id = 1,
                    PlaceFull = "Нью-Йоркская Фондовая Бираж",
                    PlaceShort = "NYSE"
                }
            );

            this.ListDealPlace.Add(
                new DealPlace
                {
                    Id = 2,
                    PlaceFull = "Лондонская фондовая биржа",
                    PlaceShort = "LSE"
                }
            );

            this.ListDealPlace.Add(
                new DealPlace
                {
                    Id = 3,
                    PlaceFull = "Московская биржа",
                    PlaceShort = "MOEX"
                }
            );

            this.ListDealPlace.Add(
                new DealPlace
                {
                    Id = 4,
                    PlaceFull = "Токийская фондовая биржа",
                    PlaceShort = "TSE"
                }
            );

            this.ListDealPlace.Add(
                new DealPlace
                {
                    Id = 5,
                    PlaceFull = "Шанхайская фондовая биржа",
                    PlaceShort = "SSE"
                }
            );
        }
    }
}
