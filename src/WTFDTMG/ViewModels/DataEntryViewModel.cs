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
    }
}
