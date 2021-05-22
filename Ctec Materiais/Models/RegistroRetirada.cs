using Ctec_Materiais.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace Ctec_Materiais.Models
{
    public class RegistroRetirada
    {
        [Key]
        public int IdRetirada { get; set; }

        public DateTime Retirada { get; set; }
        public StatusRetirada Status { get; set; }
        public Usuario Usuario { get; set; }
        public int TotalRetiradas { get; set; }

        public RegistroRetirada()
        { }

        public RegistroRetirada(int idRetirada, DateTime retirada, StatusRetirada status, Usuario usuario)
        {
            IdRetirada = idRetirada;
            Retirada = retirada;
            Status = status;
            Usuario = usuario;
        }
    }
}
