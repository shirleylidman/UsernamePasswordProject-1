using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using UsernamePasswordProject.Models;
using Xamarin.Forms;

namespace UsernamePasswordProject.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public Command SaveCommand { get; }

        private ObservableCollection<Account> _userListView;

        public event PropertyChangedEventHandler PropertyChanged;

        private string Username_;
        private string Password_;

        public MainPageViewModel()
        {

            _userListView = new ObservableCollection<Account>();

            SaveCommand = new Command(() =>
            {
                var _user = new Account
                {
                    Username = Username_,
                    Password = Password_

                };

                _userListView.Add(_user);
               

                Username = string.Empty;
                Password = string.Empty;

            });

        }

        public ObservableCollection<Account> userListView
        {
            get { return _userListView; }
            set
            {
                if (_userListView != value)
                {
                    _userListView = value;
                    var args = new PropertyChangedEventArgs(nameof(userListView));
                    PropertyChanged?.Invoke(this, args);
                }
            }
        }

        public string Username
        {
            get => Username_;
            set
            {
                if (Username_ != value)
                {
                    Username_ = value;
                    var args = new PropertyChangedEventArgs(nameof(Username));
                    PropertyChanged?.Invoke(this, args);
                }
            }
        }

        public string Password
        {
            get => Password_;
            set
            {
                if (Password_ != value)
                {
                    Password_ = value;
                    var args = new PropertyChangedEventArgs(nameof(Password));
                    PropertyChanged?.Invoke(this, args);
                }
            }
        }


    }
}
