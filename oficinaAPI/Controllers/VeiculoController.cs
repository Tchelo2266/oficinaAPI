using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using oficinaAPI.Data;
using oficinaAPI.Data.Dtos.TipoServico;
using oficinaAPI.Data.Dtos.Veiculo;
using oficinaAPI.Models;

namespace oficinaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculoController : ControllerBase
    {
        private OficinaContext _context;
        private IMapper _mapper;

        public VeiculoController(OficinaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateVeiculoDto veiculoDto) 
        {
            Veiculo veiculo = _mapper.Map<Veiculo>(veiculoDto);
            veiculo.DataCadastro = DateTime.Now;
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { veiculo.Id, veiculo.ClienteId }, veiculo);
        }

        [HttpGet]
        public IEnumerable<ReadVeiculoDto> GetAll()
        {
            IEnumerable<ReadVeiculoDto> listaVeiculos = _mapper.Map<IEnumerable<ReadVeiculoDto>>(_context.Veiculos);
            return listaVeiculos;
        }

        [HttpGet("{id}/cliente/{clienteId}")]
        public IActionResult GetById(int id, int clienteId) 
        {
            Veiculo? veiculo = _context.Veiculos.Where(x => x.ClienteId == clienteId).Where(x => x.Id == id).FirstOrDefault();
            if (veiculo != null)
            {
                ReadVeiculoDto veiculoDto = _mapper.Map<ReadVeiculoDto>(veiculo);
                return Ok(veiculoDto);
            }
            return NotFound();
        }

        [HttpGet("cliente/{id}")]
        public IEnumerable<ReadVeiculoDto> GetByClienteId(int id)
        {
            IEnumerable<ReadVeiculoDto> listaVeiculos = _mapper.Map<IEnumerable<ReadVeiculoDto>>(_context.Veiculos.Where(x => x.ClienteId == id));
            return listaVeiculos;
        }

        [HttpPut]
        public IActionResult Put([FromBody] UpdateVeiculoDto veiculoDto)
        {
            Veiculo? veiculo = _context.Veiculos.FirstOrDefault(x => x.Id == veiculoDto.Id);
            if (veiculo == null)
            {
                return NotFound();
            }
            _mapper.Map(veiculoDto, veiculo);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
