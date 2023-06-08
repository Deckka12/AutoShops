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
        Context _context = new Context();
        public CategoryRepositories () {
            
        }
        /// <summary>
        /// Вывод категории
        /// </summary>
        /// <param name="account"></param>
        public List<Category>  ShowCategories () {

                return _context.Category.ToList();
        }
        /// <summary>
        /// Вывод категории по ключу
        /// </summary>
        /// <param name="account"></param>
        public string ShowCategoriesKey (int id) {

                return _context.Category.Where(x => x.Id == id).FirstOrDefault().NameCategory;
        }
        /// <summary>
        /// Вывод Ид категории  по имени
        /// </summary>
        /// <param name="account"></param>
        public int ShowCategorID (string name) {

                return _context.Category.Where(x => x.NameCategory == name).FirstOrDefault().Id;
        }

       /// <summary>
       /// Показать категорию по ид
       /// </summary>
       /// <param name="ID"></param>
       /// <returns></returns>
        public string ShowCategorName (int ID) {

                return _context.Category.Where(x => x.Id == ID).FirstOrDefault().NameCategory;
        }

        /// <summary>
        /// Редактирование категории
        /// </summary>
        /// <param name="old"></param>
        /// <param name="news"></param>
        public void EditCategory (Category old, Category news) {

                var neCat = _context.Category.Where(x => x.NameCategory == old.NameCategory).FirstOrDefault();
                neCat.NameCategory = news.NameCategory;
                _context.SaveChanges();

        }

        /// <summary>
        /// Добавление категории
        /// </summary>
        /// <param name="news"></param>
        public void AddCategory  (Category news) {

               _context.Category.Add(news);
                _context.SaveChanges();

        }


    }
}
