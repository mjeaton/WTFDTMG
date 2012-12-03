using System;
using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;
using Ninject;
using Ninject.Modules;
using WTFDTMG.Modules;
using WTFDTMG.ViewModels;

namespace WTFDTMG
{
	public class AppBootstrapper : Bootstrapper<IShell>
	{
        private IKernel _kernel;
		protected override void Configure() 
        {
            var modules = new INinjectModule[] { new StandardModule(), new ViewModelModule() };
            _kernel = new StandardKernel(modules);
		}

		protected override object GetInstance(Type serviceType, string key)
		{
            return _kernel.Get(serviceType);
		}

		protected override IEnumerable<object> GetAllInstances(Type serviceType)
		{
            return _kernel.GetAll(serviceType);
		}

		protected override void BuildUp(object instance)
		{
            _kernel.Inject(instance);
		}
	}
}