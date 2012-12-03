using System;
using System.Collections.Generic;
using System.Linq;
using Caliburn.Micro;
using Ninject.Modules;

namespace WTFDTMG.Modules
{
    public class StandardModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IWindowManager>().To<WindowManager>();
            Bind<IEventAggregator>().To<EventAggregator>();
        }
    }
}