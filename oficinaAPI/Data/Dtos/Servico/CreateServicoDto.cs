using System.ComponentModel.DataAnnotations;

namespace oficinaAPI.Data.Dtos.Servico
{
    public class CreateServicoDto
    {
        [Required(ErrorMessage = "A descrição é obrigatória")]
        public required string Descricao { get; set; }

        [Required(ErrorMessage = "O tipo de serviço é obrigatório")]
        public required int TipoServicoId { get; set; }

        [Required(ErrorMessage = "O cliente é obrigatório")]
        public required int ClienteId { get; set; }

        [Required(ErrorMessage = "O veículo é obrigatório")]
        public required int VeiculoId { get; set; }

        public DateTime DataCadastro { get; set; }

        public int QuemCadastrou { get; set; }
    }
}
