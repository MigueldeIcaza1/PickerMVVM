﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMDemo1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PickerMVVM : ContentPage
    {
        public PickerMVVM()
        {
            InitializeComponent();
            BindingContext = new PickerMVVMViewModel();
        }
    }
}