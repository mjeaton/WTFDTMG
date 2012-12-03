using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;
using WTFDTMG.Models;

namespace WTFDTMG.ViewModels
{
    public interface IDataEntryViewModel
    {
        DateTime Date { get; set; }
        decimal Amount { get; set; }
        ObservableCollection<IAccount> Accounts { get; set; }
        ObservableCollection<ILocation> Locations { get; set; }
        IAccount SelectedAccount { get; set; }
        ILocation SelectedLocation { get; set; }
        void Ok();
        void Cancel();
    }
}
