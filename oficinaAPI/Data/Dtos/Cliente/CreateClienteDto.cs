using System.ComponentModel.DataAnnotations;

namespace oficinaAPI.Data.Dtos.Cliente
{
    public class CreateClienteDto
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [MaxLength(255, ErrorMessage = "O nome não pode ter mais que 255 caracteres")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "O telefone é obrigatório")]
        [MaxLength(30, ErrorMessage = "O telefone não pode ter mais que 30 caracteres")]
        public required string Telefone { get; set; }

        public int QuemCadastrou { get; set; }
    }
}
