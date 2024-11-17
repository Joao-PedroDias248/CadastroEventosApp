using CadastroEventosApp.Models;
using Microsoft.Maui.Controls;

namespace CadastroEventosApp
{
    public partial class ResumoEventoPage : ContentPage
    {
        public ResumoEventoPage(Evento evento)
        {
            InitializeComponent();

            // Passa o objeto Evento para o BindingContext da página
            BindingContext = new { Evento = evento };
        }
    }
}
