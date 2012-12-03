using System;
using System.Collections.Generic;
using System.Linq;

namespace WTFDTMG.Models
{
    public interface IPurchase
    {
        int Id { get; set; }
        DateTime PurchaseDate { get; set; }
        decimal Amount { get; set; }
        Account Account { get; set; }
        Location Location { get; set; }
        string Reason { get; set; }
        bool ForBusiness { get; set; }
    }
}
