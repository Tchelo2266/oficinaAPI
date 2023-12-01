using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace oficinaAPI.Data.Dtos.TipoServico
{
    public class CreateTipoServicoDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        [MaxLength(50)]
        public required string Descricao { get; set; }

        [DefaultValue(true)]
        public bool Ativo { get; set; } = true;

        public DateTime DataCadastro { get; set; }

        public int QuemCadastrou { get; set; }
    }
}
