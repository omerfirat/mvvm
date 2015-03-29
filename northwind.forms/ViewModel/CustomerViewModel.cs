using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Asya.Util.Wpf.Common.Library.Annotations;
using Asya.Util.Wpf.Common.Library.Bases;
using Northwind.Data;


namespace Northwind.Forms.ViewModel
{
    public sealed class CustomerViewModel : BaseSingleton<CustomerViewModel>, INotifyPropertyChanged
    {
        NorthwindEntities entities= new NorthwindEntities();
        private ObservableCollection<Customer> _customers;

        public ObservableCollection<Customer> Customers
        {
            get { return _customers; }

            set
            {

                if (_customers == value) return;

                _customers = value;
                OnPropertyChanged("Customers");
            }
        }

        private Customer _selectedCustomer;

        public Customer SelectedCustomer
        {
            get { return _selectedCustomer; }

            set
            {

                if (_selectedCustomer == value) return;

                _selectedCustomer = value;
                OnPropertyChanged("SelectedCustomer");
            }
        }

        private CustomerViewModel()
        {
            Customers = new ObservableCollection<Customer>();

            foreach (var customer in entities.Customers)
            {
                Customers.Add(customer);
            }

            SelectedCustomer = Customers.FirstOrDefault();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        private void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
