﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Threading.Tasks;

[assembly:XamlCompilation(XamlCompilationOptions.Compile)]
namespace ToDooList
{
    public interface IAuthenticate
    {
        Task<bool> Authenticate();
    }
    public class App : Application
	{

        public static IAuthenticate Authenticator { get; private set; }

        public static void Init(IAuthenticate authenticator)
        {
            Authenticator = authenticator;
        }

        public App ()
		{
			// The root page of your application
			//MainPage = new MainMenu();
            MainPage = new NavigationPage(new MainMenu());
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

