using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Dtos
{
   
    public class CategoryDTO
    {
        public int IdCategories { get; set; }
        public string LibelleCategorie { get; set; }
        public int IdTypesProduits { get; set; }
        //public virtual TypesProduit TypesProduits { get; set; }
        //public virtual ICollection<Article> Articles { get; set; }
    }
    public class CategoryDTOIn
    {
        public string LibelleCategorie { get; set; }
        public int IdTypesProduits { get; set; }
    }

    public class CategoryDTOOut
    {

        public int IdCategories { get; set; }
        public string LibelleCategorie { get; set; }
        //public virtual ICollection<Article> Articles { get; set; }

    }
}
