using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos1.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
            _context = context;
        }

          

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
           var eventos = _context.Eventos;
           return eventos;
        }

        [HttpGet("{id}")]
        public Evento GetById(int id)
        {
           return _context.Eventos.FirstOrDefault(x => x.EventoId == id);
        }
        [HttpPost]
        public string Post()
        {
           return "exemplo 2";
        }
    }
}
