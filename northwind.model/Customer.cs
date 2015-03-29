using System;
using System.ComponentModel;
using Asya.Util.Wpf.Common.Library.Entity;

namespace Northwind.Model
{
    public sealed class Customer : BaseEntity
    {
        private string _name;

        public string Name
        {
            get { return _name; }

            set
            {

                if (_name == value) return;

                _name = value;
                OnPropertyChanged("Name");
            }
        }

        private string _surname;

        public string Surname
        {
            get { return _surname; }

            set
            {

                if (_surname == value) return;

                _surname = value;
                OnPropertyChanged("Surname");
            }
        }

        private DateTime _birthdate;

        public DateTime Birthdate
        {
            get { return _birthdate; }

            set
            {

                if (_birthdate == value) return;

                _birthdate = value;
                OnPropertyChanged("Birthdate");
            }
        }
    }
}
