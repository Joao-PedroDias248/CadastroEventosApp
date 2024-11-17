using System;

namespace CadastroEventosApp.Models
{
    public class Evento
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int NumeroParticipantes { get; set; }
        public required string Local { get; set; }

        public Evento(string local)
        {
            Local = local;
        }

        public Evento()
        {
        }

        public decimal CustoPorParticipante { get; set; }

        // Propriedades calculadas
        public int DuracaoEmDias => (DataFim - DataInicio).Days;

        public decimal CustoTotal => NumeroParticipantes * CustoPorParticipante;

        internal class local : Evento
        {
        }
    }
}
