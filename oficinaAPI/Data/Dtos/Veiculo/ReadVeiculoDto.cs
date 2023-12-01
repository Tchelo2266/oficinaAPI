using System.ComponentModel.DataAnnotations.Schema;

namespace oficinaAPI.Data.Dtos.Veiculo
{
    public class ReadVeiculoDto
    {
        public int Id { get; set; }

        public required string Marca { get; set; }

        public required string Modelo { get; set; }

        public required string Placa { get; set; }

        public DateTime DataCadastro { get; set; }

        public int QuemCadastrou { get; set; }
    }
}
