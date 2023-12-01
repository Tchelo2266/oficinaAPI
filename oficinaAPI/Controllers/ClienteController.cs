using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using oficinaAPI.Data;
using oficinaAPI.Data.Dtos.Cliente;
using oficinaAPI.Models;
using System.Collections.Generic;

namespace oficinaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        private OficinaContext _context;
        private IMapper _mapper;

        public ClienteController(OficinaContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateClienteDto clienteDto) 
        {
            Cliente cliente = _mapper.Map<Cliente>(clienteDto);
            cliente.DataCadastro = DateTime.Now;
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { cliente.Id }, cliente);
        }

        [HttpGet]
        public IEnumerable<ReadClienteDto> GetAll()
        {
            IEnumerable<ReadClienteDto> listaClientes = _mapper.Map<IEnumerable<ReadClienteDto>>(_context.Clientes);
            return listaClientes;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            Cliente? cliente = _context.Clientes.FirstOrDefault(x => x.Id == id);
            if (cliente != null)
            {
                ReadClienteDto clienteDto = _mapper.Map<ReadClienteDto>(cliente);
                return Ok(clienteDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateClienteDto clienteDto)
        {
            Cliente? cliente = _context.Clientes.FirstOrDefault(x => x.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }
            _mapper.Map(clienteDto, cliente);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
