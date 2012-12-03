using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WTFDTMG.Models;
using ImpromptuInterface;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace WTFDTMG.ViewModels
{
    public class DataEntryViewModel : Screen, IDataEntryViewModel, IDataErrorInfo
    {
        public DataEntryViewModel()
        {
            DisplayName = "Enter Items";

            var account = new Account();
            Accounts = new ObservableCollection<IAccount>(Impromptu.AllActLike<IAccount>(account.All(), typeof(IAccount)));

            var location = new Location();
            Locations = new ObservableCollection<ILocation>(Impromptu.AllActLike<ILocation>(location.All(), typeof(ILocation)));

            Date = DateTime.Today;
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
        public ObservableCollection<ILocation> Locations { get; set; }

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

        private ILocation _selectedLocation;
        public ILocation SelectedLocation
        {
            get { return _selectedLocation; }
            set
            {
                _selectedLocation = value;
                NotifyOfPropertyChange(() => SelectedLocation);
            }
        }

        public string Reason { get; set; }

        public void Ok()
        {
            MessageBox.Show("ok");
        }

        public bool CanOk
        {
            get 
            { 
                return false; 
            }
        }

        public void Cancel()
        {
            MessageBox.Show("Cancel");
        }

        public string Error
        {
            get { throw new NotImplementedException(); }
        }

        public string this[string columnName]
        {
            get 
            {
                string returnVal = string.Empty;
                if (columnName == "Date")
                {
                    if (Date <= DateTime.MinValue || Date >= DateTime.MaxValue)
                    {
                        returnVal = "Please enter a value date.";
                    }
                }
                else if (columnName == "Reason")
                {
                    if (string.IsNullOrEmpty(Reason))
                    {
                        returnVal = "Please enter a reason / description of the purchase.";
                    }
                }
                return returnVal;
            }
        }
    }
}
