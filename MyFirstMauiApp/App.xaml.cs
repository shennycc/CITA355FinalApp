﻿using MyFirstMauiApp;
namespace MyFirstMauiApp;
public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new LoginPage());
    }
}
