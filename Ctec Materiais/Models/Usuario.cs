using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Ctec_Materiais.Models
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }

        public string Nome { get; set; }
        public string Email { get; set; }

        public Material Material { get; set; }
        public ICollection<RegistroRetirada> Retiradas { get; set; } = new List<RegistroRetirada>();

        public Usuario()
        { }

        public Usuario(int idUsuario, string nome, string email, Material material)
        {
            IdUsuario = idUsuario;
            Nome = nome;
            Email = email;
            Material = material;
        }

        public void AddMateriais(RegistroRetirada rr)
        {
            Retiradas.Add(rr);
        }

        public void RemoveMateriais(RegistroRetirada rr)
        {
            Retiradas.Remove(rr);
        }

        public int TotalRetiradas(DateTime inicial, DateTime final)
        {
            return Retiradas
                .Where(rr => rr.Retirada >= inicial && rr.Retirada <= final)
                .Sum(rr => rr.TotalRetiradas);
        }
    }
}
