using Xamarin.Forms;

namespace HolaMoviles
{
	public partial class MaestroDetallePage
	{
		public MaestroDetallePage ()
		{
			InitializeComponent ();

            var paginaMenu = new MenuPage();

            paginaMenu.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Clase 1"
            });

            paginaMenu.Menu.Add(new MenuItem()
            {
                Icon = "",
                Title = "Clase 2"
            });

            Master = paginaMenu;


            /*
            botonNavegar.Command = new Command(() => {
                Detail = new TabulacionPage();
            });
            */
        }
	}
}