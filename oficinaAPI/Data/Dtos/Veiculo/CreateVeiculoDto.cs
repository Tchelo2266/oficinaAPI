using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oficinaAPI.Data.Dtos.Veiculo
{
    public class CreateVeiculoDto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ClienteId { get; set; }

        [Required(ErrorMessage = "A marca é obrigatória")]
        public required string Marca { get; set; }

        [Required(ErrorMessage = "O modelo é obrigatório")]
        public required string Modelo { get; set; }

        [Required(ErrorMessage = "A placa é obrigatória")]
        public required string Placa { get; set; }

        public DateTime DataCadastro { get; set; }

        public int QuemCadastrou { get; set; }
    }
}
