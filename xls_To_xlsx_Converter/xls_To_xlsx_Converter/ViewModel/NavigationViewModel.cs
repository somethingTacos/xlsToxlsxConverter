﻿using System.ComponentModel;

namespace xls_To_xlsx_Converter.ViewModel
{
    public class NavigationViewModel : INotifyPropertyChanged
    {
        private object _selectedViewModel;

        public object SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                RaisePropertyChanged("SelectedViewModel");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}