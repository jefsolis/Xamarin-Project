using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HolaMoviles
{
	public partial class MainPage : ContentPage
	{

        //https://codeshare.io/G8zoBJ
        public MainPage()
        {
            InitializeComponent();

            Boton1.Clicked += async (sender, args) =>
            {
                await DisplayAlert("Saludos", "Hola Xamarin.Forms!", "Cerrar");

                LabelSalida.Text = $"Fecha:{DatePickerFechaNacimiento.Date}";

            };
            boton2.Clicked += MostrarPantalla;
        }

        private async void MostrarPantalla(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new MainPage());

            //await Navigation.PushAsync(new ContenedorPage());

            await Navigation.PushAsync(new ContenedorRemotoPage());
        }
    }
}
