using Caliburn.Micro;
namespace WTFDTMG.ViewModels
{
    public class ShellViewModel : IShell 
    {
        public ShellViewModel(INavigationViewModel navigation)
        {
            Navigation = navigation;
            var dashboard = IoC.Get<INavigationItem>();
            dashboard.Name = "Dashboard";
            Navigation.Items.Add(dashboard);
        }

        public INavigationViewModel Navigation
        {
            get;
            set;
        }

        public IContent Content
        {
            get;
            set;
        }
    }
}