using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oficinaAPI.Models
{
    public class TipoServico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [MaxLength(50)]
        public required string Descricao { get; set; }

        public virtual ICollection<Servico>? Servicos { get; set; }
        
        [DefaultValue(true)]
        public bool Ativo {  get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public int QuemCadastrou { get; set; }
    }
}
