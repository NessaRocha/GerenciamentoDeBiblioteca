using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciamentoDeBiblioteca.Domain.Entities;

namespace GerenciamentoDeBiblioteca.Domain.Entities
{
    public class Livro : Entity
    {
        public string Titulo { get; set; }
        public Autor Autor { get; set; }

        public int? AlugadoPorId { get; set; }
        public Usuario AlugadoPor { get; set; }
        public bool Alugado => AlugadoPorId != null;
        public void AlugarLivro(Usuario usuario)
        {
            ArgumentNullException.ThrowIfNull(usuario);
            AlugadoPorId = usuario.Id;
            AlugadoPor = usuario;
        }

        public void DevolverLivro()
        {
            AlugadoPorId = null;
            AlugadoPor = null;
        }




    }
}