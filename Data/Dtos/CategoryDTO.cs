using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Dtos
{
   
    class CategoryDTO
    {
        public int IdCategories { get; set; }
        public string LibelleCategorie { get; set; }
        public int IdTypesProduits { get; set; }

        public virtual TypesProduit IdTypesProduitsNavigation { get; set; }
        public virtual ICollection<Article> Articles { get; set; }
    }
    class CategoryDTOIn
    {
        public string LibelleCategorie { get; set; }
        public int IdTypesProduits { get; set; }
    }
}
