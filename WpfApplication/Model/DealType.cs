using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApplication.Model
{
    /**
     * тип сделки
     */
    public class DealType
    {
        public int Id { get; set; }
        public string Type { get; set; }

        public DealType() { }
        public DealType(int Id, string Type)
        {
            this.Id = Id;
            this.Type = Type;
        }
    }
}
