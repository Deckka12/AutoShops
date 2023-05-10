using AutoShops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.Repositories
{
    public class CategoryRepositories
    {
        public CategoryRepositories () {
            
        }
        /// <summary>
        /// Вывод категории
        /// </summary>
        /// <param name="account"></param>
        public List<Category>  ShowCategories () {
            using(var _context = new Context())
                return _context.Category.ToList();
        }
        /// <summary>
        /// Вывод категории по ключу
        /// </summary>
        /// <param name="account"></param>
        public string ShowCategoriesKey (int id) {
            using(var _context = new Context())
                return _context.Category.Where(x => x.Id == id).FirstOrDefault().NameCategory;
        }
        /// <summary>
        /// Вывод Ид категории  по имени
        /// </summary>
        /// <param name="account"></param>
        public int ShowCategorID (string name) {
            using(var _context = new Context())
                return _context.Category.Where(x => x.NameCategory == name).FirstOrDefault().Id;
        }

       /// <summary>
       /// Показать категорию по ид
       /// </summary>
       /// <param name="ID"></param>
       /// <returns></returns>
        public string ShowCategorName (int ID) {
            using(var _context = new Context())
                return _context.Category.Where(x => x.Id == ID).FirstOrDefault().NameCategory;
        }

        /// <summary>
        /// Редактирование категории
        /// </summary>
        /// <param name="old"></param>
        /// <param name="news"></param>
        public void EditCategory (Category old, Category news) {
            using(var _context = new Context())
            {
                var neCat = _context.Category.Where(x => x.NameCategory == old.NameCategory).FirstOrDefault();
                neCat.NameCategory = news.NameCategory;
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Добавление категории
        /// </summary>
        /// <param name="news"></param>
        public void AddCategory  (Category news) {
            using(var _context = new Context())
            {
               _context.Category.Add(news);
                _context.SaveChanges();
            }
        }


    }
}
