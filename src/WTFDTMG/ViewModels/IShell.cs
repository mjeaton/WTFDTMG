using System;

namespace WTFDTMG.ViewModels
{
    public interface IShell 
    {
        INavigationViewModel Navigation { get; set; }
        INavigationItem ActiveItem { get; set; }
    }
}