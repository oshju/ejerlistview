using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ejerlistview
{
    public partial class MyPage : ContentPage
    {
        public MyPage(List<Empleado> empleados)
        {
            InitializeComponent();
            controllerlistview.ItemsSource = empleados;
        }
    }
}
