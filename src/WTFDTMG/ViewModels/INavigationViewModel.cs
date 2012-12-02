using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace WTFDTMG.ViewModels
{
    public interface INavigationViewModel
    {
        ObservableCollection<INavigationItem> Items { get; set; }
    }
}
