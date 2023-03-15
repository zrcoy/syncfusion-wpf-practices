using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace syncfusion_wpf_app_datagrid
{
    public class Person
    {
        public ImageSource? Image { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Organization { get; set; }
        public string DateOfBirth { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? TileColor { get; set; }
        public Person(string name, ImageSource? image, string position, string organization, string birth, string location, string phone, string email)
        {
            Name = name;
            Image = image;
            Position = position;
            Organization = organization;
            DateOfBirth = birth;
            Location = location;
            Phone = phone;
            Email = email;
        }
    }
}
