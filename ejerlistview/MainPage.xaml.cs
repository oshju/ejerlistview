using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ejerlistview
{
    public partial class MainPage : ContentPage
    {
        public List<Empleado> listaempleados { get; set; }

        public MainPage()
        {
            InitializeComponent();
            this.listaempleados = new List<Empleado>();
            this.boton.Clicked += Botonprimerapagina_Clicked;

            this.boton2.Clicked += (sender, args) =>
            {
                //DisplayAlert("Alerta", "cargando datos", "OK");
                Empleado emp = new Empleado();
                emp.deptno = int.Parse(txtdeptno.Text);
                emp.dnombre = txtdnombre.Text;
                emp.localidad = txtlocalidad.Text;
                listaempleados.Add(emp);
            };
        }
        private void Botonprimerapagina_Clicked(object sender, EventArgs e)
        {
            NavigationPage primera = new NavigationPage(new MyPage(listaempleados));
            primera.Title = "Primera Página";
            Device.BeginInvokeOnMainThread(async () => await Navigation.PushAsync(primera));
        }






    }
}
