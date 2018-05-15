using HolaMoviles.Modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HolaMoviles
{
	public partial class ControlPrincipalView
	{
        private ObservableCollection<Usuario> _datos;
        public Command RefrescarCommand { get; set; }

        public ControlPrincipalView ()
		{
            RefrescarCommand = new Command(obj => Refrescar());

            InitializeComponent ();

            BindingContext = this;

            _datos = new ObservableCollection<Usuario> {
                new Usuario { NombreUsuario = "prueba 1"},
                new Usuario { NombreUsuario = "prueba 2"},
                new Usuario { NombreUsuario = "prueba 3"}
            };

            botonAgregar.Command = new Command(obj => Agregar());
            
            listadoDatos.ItemsSource = _datos;
            listadoDatos.ItemSelected += delegate {
                var seleccionado = listadoDatos.SelectedItem as Usuario;

                App.Current.MainPage.DisplayAlert("Seleccionado:", $"{seleccionado.NombreUsuario}", "Cerrar");
            };
		}

        private async void Refrescar()
        {
            //IsBusy
            _datos.Clear();

            await Task.Delay(2 * 1000);

            _datos.Add(new Usuario { NombreUsuario = "prueba 1" });
            _datos.Add(new Usuario { NombreUsuario = "prueba 2" });
            _datos.Add(new Usuario { NombreUsuario = "prueba 3" });

            //Task.WaitAll
            //Task.WaitAny

            listadoDatos.IsRefreshing = false;
        }

        private void Agregar()
        {
            _datos.Add(new Usuario { NombreUsuario = "valor nuevo" });
        }
    }
}