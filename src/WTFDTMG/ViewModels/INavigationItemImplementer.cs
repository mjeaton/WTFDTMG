using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace WTFDTMG.ViewModels
{
    public class NavigationItem : INavigationItem
    {
        public NavigationItem()
        {

        }
        public string Name
        {
            get;
            set;
        }

        public ICommand Behavior
        {
            get;
            set;
        }
    }
}
