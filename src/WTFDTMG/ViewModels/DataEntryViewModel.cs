using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WTFDTMG.Models;
using ImpromptuInterface;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

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

            Purchases = new ObservableCollection<Purchase>();

            Date = DateTime.Today;
        }

        public ObservableCollection<Purchase> Purchases { get; set; }

        private string _Reason;
        private DateTime _Date;
        public DateTime Date
        {
            get { return _Date; }
            set
            {
                _Date = value;
                NotifyOfPropertyChange(() => Date);
                NotifyOfPropertyChange(() => HasErrors);
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

        public string Reason
        {
            get { return _Reason; }
            set
            {
                _Reason = value;
                NotifyOfPropertyChange(() => Reason);
                NotifyOfPropertyChange(() => HasErrors);
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
                return !HasErrors;
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

                if (!string.IsNullOrEmpty(returnVal))
                {
                    AddError(columnName, returnVal);
                }
                else {
                    RemoveError(columnName) ;
                }

                NotifyOfPropertyChange(() => HasErrors);
                NotifyOfPropertyChange(() => CanOk);

                return returnVal;
            }
        }

        private Dictionary<string, string> _errors = new Dictionary<string, string>();
        public bool HasErrors
        {
            get { return _errors.Count > 0; }
        }

        public string ValidationErrors
        {
            get 
            {
                var sb = new StringBuilder();
                foreach (var s in _errors.Values) 
                {
                    sb.AppendLine(s);
                }

                return sb.ToString();
            }
        }


        public void AddError(string propertyName, string error)
        {
            if ((_errors.ContainsKey(propertyName) == false))
            {
                _errors.Add(propertyName, error);
            }

            NotifyOfPropertyChange(() => HasErrors);
            NotifyOfPropertyChange(() => ValidationErrors);
        }

        public void RemoveError(string propertyName)
        {
            if ((_errors.ContainsKey(propertyName)))
            {
                _errors.Remove(propertyName);
            }

            NotifyOfPropertyChange(() => HasErrors);
            NotifyOfPropertyChange(() => ValidationErrors);
        }
    }
}
