using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WTFDTMG.ViewModels
{
    public interface INavigationItem
    {
        string Name { get; set; }
        UIElement Content { get; set; }
    }
}
