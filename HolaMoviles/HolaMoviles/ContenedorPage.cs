using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace HolaMoviles
{
	public class ContenedorPage : ContentPage
	{
        public ContenedorPage()
        {
            Title = "Listado de datos";

            var listadoDatos = new ControlPrincipalView();
            Content = listadoDatos;

            base.ToolbarItems.Add(new ToolbarItem {
                Text = "Refrescar",
                Order = ToolbarItemOrder.Secondary,
                Command = listadoDatos.RefrescarCommand
            });
		}
	}
}