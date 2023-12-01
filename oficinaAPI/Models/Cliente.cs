using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace oficinaAPI.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(255, ErrorMessage = "O nome não pode ter mais que 255 caracteres")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório")]
        [MaxLength(30, ErrorMessage = "O telefone não pode ter mais que 30 caracteres")]
        public required string Telefone { get; set; }

        public virtual ICollection<Veiculo>? Veiculos { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;

        public int QuemCadastrou { get; set; }
    }
}
