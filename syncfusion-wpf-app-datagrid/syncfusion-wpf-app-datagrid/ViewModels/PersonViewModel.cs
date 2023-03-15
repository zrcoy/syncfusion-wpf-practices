using syncfusion_wpf_app_datagrid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace syncfusion_wpf_app_datagrid
{
    public class PersonViewModel
    {
        private ObservableCollection<Person>? m_employees;
        public ObservableCollection<Person>? Employees
        {
            get { return m_employees; }
            set { m_employees = value; }
        }
        
        public PersonViewModel()
        {
            Employees = new ObservableCollection<Person>
            {
                //new Person("Eric Joplin", new BitmapImage(new Uri("pack://application:,,,/DataBinding;Component/Images/Emp_02.png")), "Chairman", "Management", "27/09/1973", "Boston", "+800 9899 9929", "Joplin@syncfusion.com"),
                //new Person("Paul Vent", new BitmapImage(new Uri("pack://application:,,,/DataBinding;Component/Images/Emp_04.png")), "Chief Executive Officer", "Management", "27/09/1975", "New York", "+800 9899 9930", "Paul@syncfusion.com"),
                //new Person("Clara Venus", new BitmapImage(new Uri("pack://application:,,,/DataBinding;Component/Images/Emp_06.png")), "Chief Executive Assistant", "Management", "27/09/1978", "California", "+800 9899 9931", "Clara@syncfusion.com"),
                //new Person("Maria Even", new BitmapImage(new Uri("pack://application:,,,/DataBinding;Component/Images/Emp_11.png")), "Executive Manager", "Operational Unit", "27/09/1970", "New York", "+800 9899 9932", "Maria@syncfusion.com"),
                //new Person("Mark Zune", new BitmapImage(new Uri("pack://application:,,,/DataBinding;Component/Images/Emp_13.png")), "Senior Executive", "Operational Unit", "27/09/1983", "Boston", "+800 9899 9933", "Mark@syncfusion.com"),
                //new Person("Robin Ranee", new BitmapImage(new Uri("pack://application:,,,/DataBinding;Component/Images/Emp_16.png")), "Manager", "Customer Service", "27/09/1985", "New Jersey", "+800 9899 9934", "Robin@syncfusion.com"),
                //new Person("Chris Marker", new BitmapImage(new Uri("pack://application:,,,/DataBinding;Component/Images/Emp_21.png")), "Team Manager", "Customer Service", "27/09/1963", "California", "+800 9899 9935", "Chris@syncfusion.com"),
                //new Person("Serra Sum", new BitmapImage(new Uri("pack://application:,,,/DataBinding;Component/Images/Emp_23.png")), "Coordinator", "Customer Service", "27/09/1961", "New York", "+800 9899 9936", "Serra@syncfusion.com"),
                //new Person("Mathew Fleming", new BitmapImage(new Uri("pack://application:,,,/DataBinding;Component/Images/Emp_25.png")), "Recruitment Manager", "Human Resource", "27/09/1986", "Boston", "+800 9899 9937", "Mathew@syncfusion.com")
                new Person("Eric Joplin", null, "Chairman", "Management", "27/09/1973", "Boston", "+800 9899 9929", "Joplin@syncfusion.com"),
                new Person("Paul Vent", null, "Chief Executive Officer", "Management", "27/09/1975", "New York", "+800 9899 9930", "Paul@syncfusion.com"),
                new Person("Clara Venus", null, "Chief Executive Assistant", "Management", "27/09/1978", "California", "+800 9899 9931", "Clara@syncfusion.com"),
                new Person("Maria Even", null, "Executive Manager", "Operational Unit", "27/09/1970", "New York", "+800 9899 9932", "Maria@syncfusion.com"),
                new Person("Mark Zune", null, "Senior Executive", "Operational Unit", "27/09/1983", "Boston", "+800 9899 9933", "Mark@syncfusion.com"),
                new Person("Robin Ranee", null, "Manager", "Customer Service", "27/09/1985", "New Jersey", "+800 9899 9934", "Robin@syncfusion.com"),
                new Person("Chris Marker", null, "Team Manager", "Customer Service", "27/09/1963", "California", "+800 9899 9935", "Chris@syncfusion.com"),
                new Person("Serra Sum", null, "Coordinator", "Customer Service", "27/09/1961", "New York", "+800 9899 9936", "Serra@syncfusion.com"),
                new Person("Mathew Fleming", null, "Recruitment Manager", "Human Resource", "27/09/1986", "Boston", "+800 9899 9937", "Mathew@syncfusion.com")
            };
        }
    }
}
