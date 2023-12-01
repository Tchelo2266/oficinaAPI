using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using oficinaAPI.Data;
using oficinaAPI.Data.Dtos.Servico;
using oficinaAPI.Data.Dtos.TipoServico;
using oficinaAPI.Models;

namespace oficinaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicoController : ControllerBase
    {
        private OficinaContext _context;
        private IMapper _mapper;

        public ServicoController(OficinaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateServicoDto servicoDto) 
        {
            Servico servico = _mapper.Map<Servico>(servicoDto);
            servico.DataCadastro = DateTime.Now;
            _context.Servicos.Add(servico);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { servico.Id }, servico);
        }

        [HttpGet]
        public IEnumerable<ReadServicoDto> GetAll()
        {
            IEnumerable<ReadServicoDto> listaServico = _mapper.Map<IEnumerable<ReadServicoDto>>(_context.Servicos);
            return listaServico;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            Servico? servico = _context.Servicos.FirstOrDefault(x => x.Id == id);
            if (servico != null)
            {
                ReadServicoDto servicoDto = _mapper.Map<ReadServicoDto>(servico);
                return Ok(servicoDto);
            }
            return NotFound();
        }

        [HttpGet("cliente/{clienteId}/veiculo/{veiculoId}")]
        public IEnumerable<ReadServicoDto> GetByClienteIdVeiculoId(int clienteId, int veiculoId)
        {
            IEnumerable<ReadServicoDto> listaServico = _mapper.Map<IEnumerable<ReadServicoDto>>(_context.Servicos.Where(x => x.ClienteId == clienteId).Where(x => x.VeiculoId == veiculoId));
            return listaServico;
        }

        [HttpPut]
        public IActionResult Put([FromBody] UpdateServicoDto servicoDto)
        {
            Servico? servico = _context.Servicos.Where(x => x.ClienteId == servicoDto.ClienteId).Where(x => x.VeiculoId == servicoDto.VeiculoId).FirstOrDefault(x => x.Id == servicoDto.Id);
            if (servico == null)
            {
                return NotFound();
            }
            _mapper.Map(servicoDto, servico);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
