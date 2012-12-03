using System;
using System.Collections.Generic;
using System.Linq;
using Massive;

namespace WTFDTMG.Models
{
    public class Purchase : DynamicModel, IPurchase
    {
        public Purchase() : base("connString", "purchase", "Id") { }

        public int Id { get; set; }
        public DateTime PurchaseDate { get; set; }
        public decimal Amount { get; set; }
        public Account Account { get; set; }
        public Location Location { get; set; }
        public string Reason { get; set; }
        public bool ForBusiness { get; set; }
    }
}
