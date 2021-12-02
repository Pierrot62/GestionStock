using GestionStock.Data.Dtos;
using GestionStock.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace GestionStock.Data.Profiles
{
    public class ArticlesProfiles : Profile
    {
        public ArticlesProfiles()
        {
            CreateMap<ArticlesDTO, Article>();
            CreateMap<Article, ArticlesDTO>();
            CreateMap<ArticlesDTOIn, Article>();
            CreateMap<Article, ArticlesDTOIn>();
            CreateMap<Article, ArticlesDTOIn>().ForMember(d => d.LibelleCategorie, o => o.MapFrom(s => s.Categorie.LibelleCategorie));
            CreateMap<Article, ArticlesDTOIn>().ForMember(d => d.LibelleTypesProduit, o => o.MapFrom(s => s.Categorie.TypesProduits.LibelleTypesProduit));

        }
    }
}
