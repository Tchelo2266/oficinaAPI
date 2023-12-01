using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oficinaAPI.Models
{
    public class Veiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "A marca é obrigatória")]
        public required string Marca { get; set; }

        [Required(ErrorMessage = "O modelo é obrigatório")]
        public required string Modelo { get; set; }

        [Required(ErrorMessage = "A placa é obrigatória")]
        public required string Placa { get; set; }

        public int ClienteId { get; set; }

        public virtual Cliente? Cliente { get; set; }

        public DateTime DataCadastro { get; set; }

        public int QuemCadastrou { get; set; }
    }
}
