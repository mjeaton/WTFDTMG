using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WTFDTMG.Models;
using ImpromptuInterface;
using System.Collections.ObjectModel;

namespace WTFDTMG.ViewModels
{
    public class DataEntryViewModel : Screen, IDataEntryViewModel
    {
        public DataEntryViewModel()
        {
            DisplayName = "Enter Items";

            var account = new Account();
            Accounts = new ObservableCollection<IAccount>(Impromptu.AllActLike<IAccount>(account.All(), typeof(IAccount)));
        }

        private DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set
            {
                _Date = value;
                NotifyOfPropertyChange(() => Date);
            }
        }

        public decimal Amount { get; set; }

        public ObservableCollection<IAccount> Accounts { get; set; }

        private IAccount _selectedAccount;
        public IAccount SelectedAccount
        {
            get { return _selectedAccount; }
            set
            {
                _selectedAccount = value;
                NotifyOfPropertyChange(() => SelectedAccount);
            }
        }

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
            MessageBox.Show("Cancel");
        }
    }
}
