using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace SMWebApp.Models
{
    public class Paciente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o nome.")]
        public string Nome { get; set; }
        public string Email { get; set; }
        [Required(ErrorMessage = "Preencha o Whatsapp")]
        public string WhatsApp { get; set; }
        [Required(ErrorMessage = "Preencha o CPF")]
        
        public string CPF { get; set; }

        public bool EmiteRecibo { get; set; } = false;

        public bool EmiteReciboIR { get; set; } = false;

        public bool EmiteReciboConvenio { get; set; } = false;
        [AllowNull]
        public bool Ativo { get; set; } = true;

        public DateTime Aniversario { get; set; }
        public bool EnviaMsgAniversario { get; set; }

        [AllowNull]
        public string CIDHD { get; set; }
        [AllowNull]
        public string Observacao { get; set; }
        [AllowNull]
        public DateTime DtHrCad { get; set; } = DateTime.Now;
        [AllowNull]
        public DateTime DtHrAlt { get; set; } = DateTime.Now;

    }
}
