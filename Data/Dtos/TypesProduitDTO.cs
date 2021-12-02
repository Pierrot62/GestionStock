using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Dtos
{
    class TypesProduitDTO
    {
        public int IdTypesProduits { get; set; }
        public string LibelleTypesProduit { get; set; }
    }

    class TypesProduitDTOIn
    {
        public string LibelleTypesProduit { get; set; }
    }
}
