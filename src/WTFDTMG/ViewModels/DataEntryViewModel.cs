using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WTFDTMG.ViewModels
{
    public class DataEntryViewModel : Screen, IDataEntryViewModel
    {
        public void Ok()
        {
            MessageBox.Show("ok");
        }

        public bool CanOk
        {
            get { return false; }
        }

        public void Cancel()
        {
        }
    }
}
