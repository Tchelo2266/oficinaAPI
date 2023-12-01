using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace oficinaAPI.Data.Dtos.TipoServico
{
    public class ReadTipoServicoDto
    {
        public int Id { get; set; }

        public required string Descricao { get; set; }
        
        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        public int QuemCadastrou { get; set; }
    }
}
