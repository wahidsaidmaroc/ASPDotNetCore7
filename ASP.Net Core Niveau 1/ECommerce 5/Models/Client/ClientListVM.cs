using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Client
{
    public class ClientListVM
    {
        public int Id { get; set; }
        public string Nom { get; set; }    = string.Empty;
        public string Prenom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Tel { get; set; }   =string.Empty;
        public string Img { get; set; } = string.Empty;
    }
}
