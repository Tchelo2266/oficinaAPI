namespace oficinaAPI.Data.Dtos.Servico
{
    public class ReadServicoDto
    {
        public int Id { get; set; }
        public required string Descricao { get; set; }

        public required int ClienteId { get; set; }

        public required int VeiculoId { get; set; }

        public required int TipoServicoId { get; set; }
        
        public bool Ativo { get; set; }

        public DateTime DataCadastro { get; set; }

        public int QuemCadastrou { get; set; }
    }
}
