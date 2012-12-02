using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace WTFDTMG.ViewModels
{
    public class DataEntryViewModel : IDataEntryViewModel
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
