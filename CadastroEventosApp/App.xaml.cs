﻿using Microsoft.Maui.Controls;
using CadastroEventosApp;

namespace CadastroEventosApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CadastroEventoPage());
        }
    }
}
