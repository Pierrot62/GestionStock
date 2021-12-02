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
    public class TypesProduitProfiles : Profile
    {
        public TypesProduitProfiles()
        {
            CreateMap<TypesProduitDTO, TypesProduit>();
            CreateMap<TypesProduit, TypesProduitDTO>(); 
            CreateMap<TypesProduitDTOIn, TypesProduit>();
            CreateMap<TypesProduit, TypesProduitDTOIn>();
        }
    }
}
