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
        Context _context;
        public CategoryRepositories () {
            _context = ContextRun.Context();
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

    }
}
