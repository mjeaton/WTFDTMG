using Caliburn.Micro;
using System;

namespace WTFDTMG.ViewModels
{
    public class ShellViewModel : IShell, IHaveDisplayName 
    {
        public ShellViewModel(INavigationViewModel navigation)
        {
            DisplayName = "WTFDTMG?";

            Navigation = navigation;

            var dashboard = IoC.Get<INavigationItem>();
            dashboard.Name = "Dashboard";
            dashboard.Content = ViewLocator.LocateForModel(IoC.Get<IDashboardViewModel>(), null, null);
            Navigation.Items.Add(dashboard);

            var entry = IoC.Get<INavigationItem>();
            entry.Name = "Enter items";
            var entryVM = IoC.Get<IDataEntryViewModel>();
            var entryV = ViewLocator.LocateForModel(entryVM, null, null);
            entry.Content = entryV;
            Navigation.Items.Add(entry);

            var admin = IoC.Get<INavigationItem>();
            admin.Name = "Administration";
            admin.Content = ViewLocator.LocateForModel(IoC.Get<IAdministrationViewModel>(), null, null);
            Navigation.Items.Add(admin);
        }

        public INavigationViewModel Navigation
        {
            get;
            set;
        }

        public string DisplayName
        {
            get;
            set;
        }

        public INavigationItem ActiveItem
        {
            get;
            set;
        }
    }
}