using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMDemo1
{
    public class ListViewViewModel
    {
        public ObservableCollection<Person> PersonsList { get; set; }

        private Person _selectedPerson { get; set; }
        public Person SelectedPerson {
            get { return _selectedPerson; }
            set
            {
                if (_selectedPerson != value)
                {
                    _selectedPerson = value;
                    // Do whatever functionality you want here...
                    HandleSelectedItem();
                }
            }
        }

        private void HandleSelectedItem()
        {
            Page page = new Page();
            page.DisplayAlert("Selected Item", "Name : " + SelectedPerson.Name + "   City : " + SelectedPerson.City, "OK");
        }

        public ListViewViewModel()
        {
            PersonsList = new ObservableCollection<Person>
            {
                new Person(){ Name = "John", City = "Los Angeles" },
                new Person(){ Name = "Rose", City = "London" },
                new Person(){ Name = "John", City = "New Delhi" },
                new Person(){ Name = "John", City = "New York" },
            };
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}
