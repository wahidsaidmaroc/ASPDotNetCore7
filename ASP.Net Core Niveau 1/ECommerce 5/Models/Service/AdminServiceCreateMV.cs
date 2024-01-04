using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Service
{
    public class AdminServiceCreateMV
    {
        [Required(ErrorMessage ="Saisir le titre")]
        public string Titre { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }
}
