﻿using System;
using System.ComponentModel;
using System.Windows.Input;

namespace PortableClassLibrary1.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand IncrementCommand { get; set; }
        public ICommand DoubleCommand { get; set; }

        private string _greeting;
        public string Greeting
        {
            get { return _greeting; }
            set
            {
                _greeting = value;
                OnPropertyChanged("Greeting");
            }
        }

        private int _total;
        public int Total
        {
            get { return _total; }
            set
            {
                _total = value;
                OnPropertyChanged("Total");
            }
        }

        public MainViewModel()
        {
            // Properties
            Greeting = "Hello World! v2";

            // Commands
            IncrementCommand = new DelegateCommand(obj => Increment());
            DoubleCommand = new DelegateCommand(obj => Double());
        }

        public void Increment()
        {
            Total += 1;
        }

        public void Double()
        {
            Total *= 2;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public class DelegateCommand : ICommand
    {
        public Action<object> ExecuteAction { get; set; }

        public DelegateCommand(Action<object> executeAction)
        {
            ExecuteAction = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            ExecuteAction(parameter);
        }
    }

}
