using System;
using System.Collections.Generic;
using System.Text;

namespace HolaMoviles
{
    public class ContenedorRemotoPage : ContenedorPage
    {
        public ApiRest Client { get; set; }

        public ContenedorRemotoPage()
        {
            Client = new ApiRest();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var json = await Client.GetJson();
        }
    }
}
