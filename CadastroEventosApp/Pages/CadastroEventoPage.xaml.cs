using CadastroEventosApp.Models;
using Microsoft.Maui.Controls;

namespace CadastroEventosApp
{
    public partial class CadastroEventoPage : ContentPage
    {
        public Evento Evento { get; set; }

        public CadastroEventoPage()
        {
            InitializeComponent();

            // Inicializando o Evento com valores padr�o
            Evento = new Evento
            {
                Nome = string.Empty,
                DataInicio = DateTime.Today,
                DataFim = DateTime.Today.AddDays(1),
                NumeroParticipantes = 0,
                Local = string.Empty,  // Inicializa a propriedade Local
                CustoPorParticipante = 0
            };

            BindingContext = Evento;
        }

        // M�todo chamado quando o bot�o "Cadastrar Evento" � clicado
        private async void OnCadastrarEventoClicked(object sender, EventArgs e)
        {
            // Navega para a p�gina de resumo e passa o objeto Evento
            await Navigation.PushAsync(new ResumoEventoPage(Evento));
        }
    }
}
