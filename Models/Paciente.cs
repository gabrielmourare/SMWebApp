using System.ComponentModel.DataAnnotations;

namespace SMWebApp.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Email { get; set; }
        [Required]
        public string WhatsApp { get; set; }
        [Required]
        public string CPF{ get; set; }
        public bool EmiteRecibo { get; set; }
        public bool EmiteReciboIR { get; set; }
        public bool EmiteReciboConvenio { get; set; }
        public bool Ativo { get; set; }
        public DateTime Aniversario { get; set; }
        public bool EnviaMsgAniversario { get; set; }
        public string CIDHD { get; set; }
        public string Observacao { get; set; }
        public DateTime DtHrCad { get; set; } = DateTime.Now;
        public DateTime DtHrAlt { get; set; }

    }
}
