using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oficinaAPI.Models
{
    public class Servico
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        public required string Descricao { get; set; }

        [Required(ErrorMessage = "O cliente é obrigatório")]
        public required int ClienteId { get; set; }

        public virtual Cliente? Cliente { get; set; }

        [Required(ErrorMessage = "O veículo é obrigatório")]
        public required int VeiculoId { get; set; }

        public virtual Veiculo? Veiculo { get; set; }

        [Required(ErrorMessage = "O tipo de serviço é obrigatório")]
        public required int TipoServicoId { get; set; }

        public virtual TipoServico? TipoServico { get; set; }

        public DateTime DataCadastro { get; set; }

        public int QuemCadastrou { get; set; }
    }
}
