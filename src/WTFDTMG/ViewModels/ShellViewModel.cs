using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Data;

namespace WTFDTMG.ViewModels
{
    public class ShellViewModel : Conductor<object>, IShell, IHandle<string>
    {
        private readonly IEventAggregator _eventAggregator;
        public ShellViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

            DisplayName = "WTFDTMG?";

            var items = new List<string>();
            items.Add("Dashboard");
            items.Add("Enter items");
            items.Add("Administration");

            _navigationItems = (CollectionView)CollectionViewSource.GetDefaultView(items);
            NavigationItems.CurrentChanged += delegate
            {
                eventAggregator.Publish(NavigationItems.CurrentItem.ToString());
            };

            _eventAggregator.Subscribe(this);
        }

        private ICollectionView _navigationItems;
        public ICollectionView NavigationItems
        {
            get { return _navigationItems; }
        }

        public void Handle(string message)
        {
            switch (message.ToLower())
            {
                case "dashboard":
                    ActivateItem(IoC.Get<IDashboardViewModel>());
                    break;
                case "enter items":
                    ActivateItem(IoC.Get<IDataEntryViewModel>());
                    break;
                case "administration":
                    ActivateItem(IoC.Get<IAdministrationViewModel>());
                    break;
            }
            Console.WriteLine(message);
        }
    }
}