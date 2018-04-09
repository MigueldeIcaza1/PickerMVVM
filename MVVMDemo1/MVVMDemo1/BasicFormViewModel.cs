using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVMDemo1
{
    public class BasicFormViewModel
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }

        public ICommand SaveCommand { get; set; }

        public BasicFormViewModel()
        {
            SaveCommand = new Command(SaveData);
        }

        public void SaveData()
        {
            Page p = new Page();
            p.DisplayAlert("Data", Name + "," + City + "," + PhoneNumber, "OK");
        }
    }
}
