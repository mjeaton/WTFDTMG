using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using WTFDTMG.Models;

namespace WTFDTMG.ViewModels
{
    public class DataEntryViewModel : Screen, IDataEntryViewModel
    {
        public DataEntryViewModel()
        {
            DisplayName = "Enter Items";

            Accounts = new ObservableCollection<Account>();
            Accounts.Add(new Account() { Name = "Checking" });
            Accounts.Add(new Account() { Name = "Savings" });
            Accounts.Add(new Account() { Name = "Amex" });
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

        public ObservableCollection<Account> Accounts { get; set; }

        private Account _selectedAccount;
        public Account SelectedAccount
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
