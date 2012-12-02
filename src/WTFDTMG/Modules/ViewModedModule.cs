using System;
using System.Collections.Generic;
using System.Linq;
using Ninject.Modules;
using WTFDTMG.ViewModels;

namespace WTFDTMG.Modules
{
    public class ViewModelModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IShell>().To<ShellViewModel>();
            Bind<INavigationViewModel>().To<NavigationViewModel>();
            Bind<INavigationItem>().To<NavigationItem>();
        }
    }
}
