using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using oficinaAPI.Data;
using oficinaAPI.Data.Dtos.Cliente;
using oficinaAPI.Data.Dtos.TipoServico;
using oficinaAPI.Models;

namespace oficinaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoServicoController : ControllerBase
    {
        private OficinaContext _context;
        private IMapper _mapper;

        public TipoServicoController(OficinaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateTipoServicoDto tipoServicoDto) 
        {
            TipoServico tipoServico = _mapper.Map<TipoServico>(tipoServicoDto);
            tipoServico.DataCadastro = DateTime.Now;
            _context.TiposServico.Add(tipoServico);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { tipoServico.Id }, tipoServico);
        }

        [HttpGet]
        public IEnumerable<ReadTipoServicoDto> GetAll()
        {
            IEnumerable<ReadTipoServicoDto> listaTiposServico = _mapper.Map<IEnumerable<ReadTipoServicoDto>>(_context.TiposServico.Where(x => x.Ativo == true));
            return listaTiposServico;
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            TipoServico? tipoServico = _context.TiposServico.FirstOrDefault(x => x.Id == id);
            if (tipoServico != null)
            {
                ReadTipoServicoDto tipoServicoDto = _mapper.Map<ReadTipoServicoDto>(tipoServico);
                return Ok(tipoServicoDto);
            }
            return NotFound();
        }
        /*
        [HttpPut]
        public IActionResult Put(int id, [FromBody] UpdateTipoServicoDto tipoServicoDto)
        {
            TipoServico? tipoServico = _context.TipoServico.FirstOrDefault(x => x.Id == id);
            if (tipoServico == null)
            {
                return NotFound();
            }
            _mapper.Map(tipoServicoDto, tipoServico);
            _context.SaveChanges();

            return NoContent();
        }
        */

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var tipoServico = _context.TiposServico.FirstOrDefault(x => x.Id == id);
            if (tipoServico != null)
            {
                tipoServico.Ativo = false;
                _context.SaveChanges();
            }
            return NoContent();
        }
    }
}
