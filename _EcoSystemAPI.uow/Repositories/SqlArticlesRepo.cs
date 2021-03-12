using EcoSystemAPI.Data;
using EcoSystemAPI.Dtos;
using EcoSystemAPI.Models;
using EcoSystemAPI.uow.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EcoSystemAPI.uow.Repositories
{
    public class SqlArticlesRepo : IArticlesRepo
    {
        private readonly EcosystemContext _context;

        public SqlArticlesRepo (EcosystemContext context)
        {
            _context = context;
        }
        public void CreateArticle(Article art)
        {
            if (art == null)
            {
                throw new ArgumentNullException(nameof(art));
            }
            _context.Article.Add(art);
        }

        public void DeleteArticle(Article art)
        {
            if (art == null)
            {
                throw new ArgumentNullException(nameof(art));
            }
            _context.Remove(art);
        }

        public IEnumerable<Article> GetAllArticles()
        {
            return _context.Article.ToList();
        }

        public Article GetArticleById(int id)
        {
            return _context.Article.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateArticle(Article art)
        {
        }


    }
}
