using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows;

namespace WTFDTMG.ViewModels
{
    public class NavigationItem : INavigationItem
    {
        public string Name
        {
            get;
            set;
        }

        private UIElement _content;
        public UIElement Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}
