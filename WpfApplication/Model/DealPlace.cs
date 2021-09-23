using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApplication.Model
{
    /**
     * место проведения сделки
     */
    public class DealPlace
    {
        public int Id { get; set; }
        public string PlaceFull { get; set; }
        public string PlaceShort { get; set; }

        public DealPlace() { }
        public DealPlace(int Id, string PlaceFull, string PlaceShort)
        {
            this.Id = Id;
            this.PlaceFull = PlaceFull;
            this.PlaceShort = PlaceShort;
        }
    }
}
