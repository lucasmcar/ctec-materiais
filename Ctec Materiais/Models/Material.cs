using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Ctec_Materiais.Models
{
    public class Material
    {
        [Key]
        public int IdMaterial { get; set; }

        [Required(ErrorMessage = "Deve conter nome do material")]
        public string Nome { get; set; }

        [StringLength(3, MinimumLength = 2)]
        public string Codigo { get; set; }

        public ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();

        public Material()
        { }

        public Material(int idMaterial, string nome, string codigo)
        {
            IdMaterial = idMaterial;
            Nome = nome;
            Codigo = codigo;
        }

        public void AddUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public void RemoveUsuario(Usuario usuario)
        {
            Usuarios.Remove(usuario);
        }

        public int TotalMaterialRetirado(DateTime inicial, DateTime final)
        {
            return Usuarios.Sum(usuario => usuario.TotalRetiradas(inicial, final));
        }

        
    }
}
