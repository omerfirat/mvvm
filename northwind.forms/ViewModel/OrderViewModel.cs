
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using Asya.Util.Wpf.Common.Library.Annotations;
using Asya.Util.Wpf.Common.Library.Bases;
using Northwind.Data;


namespace Northwind.Forms.ViewModel
{

    public sealed class OrderViewModel : BaseSingleton<OrderViewModel>, INotifyPropertyChanged
    {
        private readonly NorthwindEntities entities;
        private ObservableCollection<Order> _order;

        public ObservableCollection<Order> Orders
        {
            get { return _order; }

            set
            {

                if (_order == value)
                    return;

                _order = value;
                OnPropertyChanged("Orders");
            }
        }

        private Order _selectedOrder;

        public Order SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                if (value != _selectedOrder)
                {
                    _selectedOrder = value;
                    OnPropertyChanged("SelectedOrder");
                    SelectedDetails = entities.Order_Details.Where(x => x.Order_ID == _selectedOrder.Order_ID).ToList();
                }
            }
        }

        private ICollection<Order_Detail> _selectedDetails;

        public ICollection<Order_Detail> SelectedDetails
        {
            get { return _selectedDetails; }
            set
            {
                if (_selectedDetails==value) return;

                _selectedDetails = value;
                OnPropertyChanged("SelectedDetails");

            }
        }

        public List<Product> ProductList
        {
            get
            {
                return _productList;              
            }
            set
            {
                if (_productList == value) return;

                _productList = value;
                OnPropertyChanged("ProductList");
            }
        }

        private List<Product> _productList; 

        public OrderViewModel()
        {
            entities = new NorthwindEntities();
            Orders = new ObservableCollection<Order>();

            ProductList = entities.Products.ToList();

            foreach (var order in entities.Orders)
            {
                Orders.Add(order);
            }

            SelectedOrder = Orders.FirstOrDefault();
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