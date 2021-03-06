﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

[assembly: Xamarin.Forms.Xaml.XamlCompilation(Xamarin.Forms.Xaml.XamlCompilationOptions.Compile)]
namespace HolaMoviles
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            var mainPage = new MaestroDetallePage()
            {
                Title = "Curso de Xamarin"
            };

            MainPage = new NavigationPage(mainPage);
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
