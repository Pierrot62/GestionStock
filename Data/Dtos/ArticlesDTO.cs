using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Dtos
{
    class ArticlesDTO
    {
        public string LibelleArticle { get; set; }
        public int QuantiteStockee { get; set; }
        public virtual Category Categories { get; set; }
    }

    class ArticlesDTOIn
    {
        public string LibelleArticle { get; set; }
        public int QuantiteStockee { get; set; }
        public int IdCategorie { get; set; }
        public string LibelleCategorie { get; set; }
        public string LibelleTypesProduit { get; set; }
    }

    //class ArticlesDTOIn
    //{
    //    public string LibelleArticle { get; set; }
    //    public int QuantiteStockee { get; set; }
    //    public int IdCategories { get; set; }
    //}
}
