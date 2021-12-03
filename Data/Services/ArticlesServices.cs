﻿using GestionStock.Data.Dtos;
using GestionStock.Data.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Data.Services
{
    class ArticlesServices
    {

        private readonly MyDbContext _context;

        public ArticlesServices(MyDbContext context)
        {
            _context = context;
        }

        public void AddArticle(Article obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Articles.Add(obj);
            _context.SaveChanges();
        }

        public void DeleteArticle(Article obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }
            _context.Articles.Remove(obj);
            _context.SaveChanges();
        }

        public IEnumerable<Article> GetAllArticles()
        {
            //return _context._mapper.Map<IEnumerable<ArticlesDTOIn>>(_context.Articles.ToList());
            return _context.Articles.Include("Categorie").ToList();
        }

        public Article GetArticleById(int id)
        {
            return _context.Articles.FirstOrDefault(obj => obj.IdArticle == id);
        }

        public void UpdateArticle(Article obj)
        {
            _context.SaveChanges();
        }


    }
}
