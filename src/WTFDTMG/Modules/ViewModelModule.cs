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
            Bind<IDashboardViewModel>().To<DashboardViewModel>();
            Bind<IDataEntryViewModel>().To<DataEntryViewModel>();
            Bind<IAdministrationViewModel>().To<AdministrationViewModel>();
        }
    }
}
