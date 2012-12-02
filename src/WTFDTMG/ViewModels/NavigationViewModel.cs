using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.ObjectModel;

namespace WTFDTMG.ViewModels
{
    public class NavigationViewModel : INavigationViewModel
    {
        public NavigationViewModel()
        {
            Items = new ObservableCollection<INavigationItem>();
        }

        public ObservableCollection<INavigationItem> Items { get; set; }

    }
}
