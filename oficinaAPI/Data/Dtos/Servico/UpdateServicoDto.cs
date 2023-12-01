using System.ComponentModel.DataAnnotations;

namespace oficinaAPI.Data.Dtos.Servico
{
    public class UpdateServicoDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória")]
        public required string Descricao { get; set; }

        [Required(ErrorMessage = "O cliente é obrigatório")]
        public required int ClienteId { get; set; }

        [Required(ErrorMessage = "O veículo é obrigatório")]
        public required int VeiculoId { get; set; }

        [Required(ErrorMessage = "O tipo de serviço é obrigatório")]
        public required int TipoServicoId { get; set; }
    }
}
