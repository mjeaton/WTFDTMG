using System;

namespace WTFDTMG.ViewModels
{
    public interface IShell 
    {
        INavigationViewModel Navigation { get; set; }
        IContent Content { get; set; }
    }
}