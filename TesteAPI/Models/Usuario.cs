using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteAPI.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

        public List<Usuario> Listar() => new List<Usuario>()
        {
            new Usuario
            {
                Id = 1,
                Nome = "Eduardo",
                Senha = "111",
                Email = "eduardo@gmail.com"
            },
            new Usuario
            {
                Id = 2,
                Nome = "Teste API",
                Senha = "teste",
                Email = "teste@gmail.com"
            }
        };

        public Usuario Obter(int id) => Listar().FirstOrDefault(it => it.Id == id);

        public void IncluirUsuario(Usuario usuario) => Listar().Add(usuario);

        public void Excluir(int id)
        {
            var usuario = Obter(id);
            Listar().Remove(usuario);
        }

        public Usuario Alterar(int id, Usuario usuario)
        {
            var usuAlterar = Obter(id);
            usuAlterar.Nome = usuario.Nome;
            usuAlterar.Senha = usuario.Senha;
            usuAlterar.Email = usuario.Email;

            return usuAlterar;
        }
    }
}
