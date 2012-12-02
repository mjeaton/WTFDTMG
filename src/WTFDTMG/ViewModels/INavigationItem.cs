using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace WTFDTMG.ViewModels
{
    public interface INavigationItem
    {
        string Name { get; set; }
        ICommand Behavior { get; set; }
    }
}
