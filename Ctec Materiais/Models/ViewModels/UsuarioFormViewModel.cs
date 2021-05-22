using System.Collections.Generic;

namespace Ctec_Materiais.Models.ViewModels
{
    public class UsuarioFormViewModel
    {
        public Usuario Usuario { get; set; }
        public  ICollection<Material> Materiais { get; set; }
    }
}
