using Syncfusion.Data;
using syncfusion_wpf_app_datagrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace syncfusion_wpf_app_datagrid
{
    public class CustomerNameComparer : IComparer<Object>, ISortDirection
    {

        public int Compare(object x, object y)
        {
            int lengthNameX;
            int lengthNameY;


            if (x.GetType() == typeof(OrderInfo))
            {
                lengthNameX = ((OrderInfo)x).CustomerName.Length;
                lengthNameY = ((OrderInfo)y).CustomerName.Length;
            }
            else if (x.GetType() == typeof(Group))
            {


                lengthNameX = ((Group)x).Key.ToString()!.Length;
                lengthNameY = ((Group)y).Key.ToString()!.Length;


            }
            else
            {
                lengthNameX = x.ToString()!.Length;
                lengthNameY = y.ToString()!.Length;
            }


            if (lengthNameX.CompareTo(lengthNameY) > 0)
                return SortDirection == ListSortDirection.Ascending ? 1 : -1;

            else if (lengthNameX.CompareTo(lengthNameY) == -1)
                return SortDirection == ListSortDirection.Ascending ? -1 : 1;

            else
                return 0;
        }

        private ListSortDirection m_SortDirection;
        public ListSortDirection SortDirection
        {
            get { return m_SortDirection; }
            set { m_SortDirection = value; }
        }
    }
}
