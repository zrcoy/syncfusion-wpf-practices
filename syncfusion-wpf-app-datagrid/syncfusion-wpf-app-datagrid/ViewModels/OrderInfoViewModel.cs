using syncfusion_wpf_app_datagrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion_wpf_app_datagrid
{
    public class OrderInfoViewModel
    {
        private ObservableCollection<OrderInfo> m_orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return m_orders; }
            set { m_orders = value; }
        }

        public OrderInfoViewModel()
        {
            m_orders = new ObservableCollection<OrderInfo>();
            GenerateOrders();
        }

        private void GenerateOrders()
        {
            m_orders.Add(new OrderInfo(1001, "Maria Anders", "Germany", "ALFKI", "Berlin"));
            m_orders.Add(new OrderInfo(1002, "Ana Trujilo", "Mexico", "ANATR", "Mexico D.F."));
            m_orders.Add(new OrderInfo(1003, "Antonio Moreno", "Mexico", "ANTON", "Mexico D.F."));
            m_orders.Add(new OrderInfo(1004, "Thomas Hardy", "UK", "AROUT", "London"));
            m_orders.Add(new OrderInfo(1005, "Christina Berglund", "Sweden", "BERGS", "Lula"));
            m_orders.Add(new OrderInfo(1006, "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
            m_orders.Add(new OrderInfo(1007, "Frederique Citeaux", "France", "BLONP", "Strasbourg"));
            m_orders.Add(new OrderInfo(1008, "Martin Sommer", "Spain", "BOLID", "Madrid"));
            m_orders.Add(new OrderInfo(1009, "Laurence Lebihan", "France", "BONAP", "Marseille"));
            m_orders.Add(new OrderInfo(1010, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen"));
        }
    }
}
