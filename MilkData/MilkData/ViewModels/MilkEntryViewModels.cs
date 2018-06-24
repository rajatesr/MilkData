using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace MilkData.ViewModels
{
    public class MilkEntryViewModels : INotifyPropertyChanged
    {
        public MilkEntryViewModels()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #region Ref
        private DateTime _selectedDate;
        public DateTime SelectedDate
        {
            get { return _selectedDate; }
            set
            {
                _selectedDate = value;
                OnPropertyChanged();
            }
        }
        private string _number;
        public string Number
        {
            get { return _number; }
            set
            {
                _number = value;
                OnPropertyChanged();
            }
        }
        private decimal _milk;
        public decimal Milk
        {
            get { return _milk; }
            set
            {
                _milk = value;
                OnPropertyChanged();
                Amount = _milk * _fact;
            }
        }
        private decimal _fact;
        public decimal Fact
        {
            get { return _fact; }
            set
            {
                _fact = value;
                OnPropertyChanged();
                Amount = _milk * _fact;

            }
        }
        private decimal _amout;
        public decimal Amount
        {
            get { return _amout; }
            set
            {
                _amout = value;
                OnPropertyChanged();
            }
        }
        #endregion

    }
}
