using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVMDemo1
{
    public class PickerMVVMViewModel : INotifyPropertyChanged
    {
        public List<City> CitiesList { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

        private string _myCity;
        public string MyCity
        {
            get { return _myCity; }
            set
            {
                if (_myCity != value)
                {
                    _myCity = value;
                    OnPropertyChanged();
                }
            }
        }

        private City _selectedCity { get; set; }
        public City SelectedCity
        {
            get { return _selectedCity; }
            set
            {
                if (_selectedCity != value)
                {
                    _selectedCity = value;
                    // Do whatever functionality you want...When a selectedItem is changed..
                    // write code here..
                    MyCity = "Selected City : " + _selectedCity.Value;
                }
            }
        }

        



        public PickerMVVMViewModel()
        {
            CitiesList = GetCities().OrderBy(t => t.Value).ToList();
            MyCity = "Selected City : ";
        }
        public List<City> GetCities()
        {
            var cities = new List<City>()
            {
                new City(){Key =  1, Value= "Mumbai"},
                new City(){Key =  2, Value= "Bengaluru"},
                new City(){Key =  3, Value= "Pune"},
                new City(){Key =  4, Value= "Chennai"},
                new City(){Key =  5, Value= "Ahmedabad"},
                new City(){Key =  6, Value= "Hyderabad"},
                new City(){Key =  7, Value= "Kolkata"}
            };

            return cities;
        }
    }


    public class City
    {
        public int Key { get; set; }
        public string Value { get; set; }
    }
}
