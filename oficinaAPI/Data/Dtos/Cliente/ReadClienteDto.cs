using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace oficinaAPI.Data.Dtos.Cliente
{
    public class ReadClienteDto
    {
        public int Id { get; set; }

        public required string Nome { get; set; }

        public required string Telefone { get; set; }

        public DateTime DataCadastro { get; set; }

        public int QuemCadastrou { get; set; }
    }
}
