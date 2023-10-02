namespace SMWebApp.Models
{
    public class Recibo
    {
        public int Id { get; set; }
        public string CPFPaciente { get; set; }
        public Decimal Valor { get; set; }
        public string ValorExtenso { get; set; }
        public DateTime DtConsulta { get; set; }
        public DateTime DtEmissao { get; set; }
        public DateTime Aniversario { get; set; }
        public string CIDHD { get; set; }
        public string NomePaciente { get; set; }
    }
}
