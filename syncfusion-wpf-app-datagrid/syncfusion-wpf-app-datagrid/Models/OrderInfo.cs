using Syncfusion.UI.Xaml.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion_wpf_app_datagrid
{
    public class OrderInfo : INotifyPropertyChanged
    {
        private int m_orderID;
        private string m_customerId;
        private string m_country;
        private string m_customerName;
        private string m_shippingCity;

        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity)
        {
            OrderID = orderId;
            m_orderID=orderId;
            CustomerName = customerName;
            m_customerName = customerName;
            Country = country;
            m_country = country;
            CustomerID = customerId;
            m_customerId = customerId;
            ShipCity = shipCity;
            m_shippingCity = shipCity;
            PropertyChanged = null;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public int OrderID
        {
            get { return m_orderID; }
            set
            {
                m_orderID = value;

                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged(nameof(OrderID));
            }
        }

        public string CustomerID
        {
            get { return m_customerId; }
            set
            {
                m_customerId = value;

                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged(nameof(CustomerID));
            }
        }

        public string CustomerName
        {
            get { return m_customerName; }
            set
            {
                m_customerName = value;

                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged(nameof(CustomerName));
            }
        }

        public string Country
        {
            get { return m_country; }
            set
            {
                m_country = value;

                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged(nameof(Country));
            }
        }

        public string ShipCity
        {
            get { return m_shippingCity; }
            set
            {
                m_shippingCity = value;

                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged(nameof(ShipCity));
            }
        }



        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
