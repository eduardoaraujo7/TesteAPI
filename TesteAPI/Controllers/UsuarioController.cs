using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteAPI.Models;

namespace TesteAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        Usuario Usuario = new Usuario();

        [HttpGet]
        public IActionResult Listar()
        {
            var usuarios = Usuario.Listar();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult Obter(int id)
        {
            var usuario = Usuario.Obter(id);
            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Incluir([FromBody] Usuario usuario)
        {
            Usuario.IncluirUsuario(usuario);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Alterar([FromBody] Usuario usuario, int id)
        {
            Usuario.Alterar(id, usuario);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Excluir(int id)
        {
            Usuario.Excluir(id);
            return Ok();
        }
    }
}
