using AutoShops.DBL;
using AutoShops.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.Repositories
{
    public class ProductRepositories
    {
        Context _context;
        public ProductRepositories () {
            _context = new Context();
        }
        CategoryRepositories categoryRepositories = new CategoryRepositories();
        /// <summary>
        /// Вывод товаров
        /// </summary>
        /// <returns></returns>
        public List<Product> ShowOrders () {

                return _context.Product.Include(x=>x.Category).ToList();

              
        }

        /// <summary>
        /// Вывод товаров по категории
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Product> ShowOrdersCategory (string name) {

                return _context.Product.Include(x => x.Category).Where(x => x.CategoryID == categoryRepositories.ShowCategorID(name)).ToList();
        }
        /// <summary>
        /// Вывод товара по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Product> ShowOrdersName (string name) {

                return _context.Product.Include(x => x.Category).Where(x => x.Name == name).ToList();
        }
        public List<Product> ShowOrdersContainsNameOrArticle (string name) {
            if(_context.Product.Include(x => x.Category).Where(x => x.Name.Contains(name)).Count()>0)
                return _context.Product.Include(x => x.Category).Where(x => x.Name.Contains(name)).ToList();
            else
                return _context.Product.Include(x => x.Category).Where(x => x.Articl.Contains(name)).ToList();
        }
        /// <summary>
        /// Вывод количества опредленного товара
        /// </summary>
        /// <param name="name"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public Product ShowOrdersNameCount (string name, int count) {

            
                if(_context.Product.Where(x => x.Name.Contains(name) && x.Count >= count).Count() == 1)
                    return _context.Product.Where(x => x.Name.Contains(name)).FirstOrDefault();
                else
                    return null;
            

        }
        /// <summary>
        /// редактирование товара
        /// </summary>
        /// <param name="old"></param>
        /// <param name="newProduct"></param>
        public void EditProduct (Product old, Product newProduct) {

                old = _context.Product.Where(x => x.Name == old.Name).FirstOrDefault();
                old.Price = newProduct.Price;
                old.CategoryID = newProduct.CategoryID;
                old.Name = newProduct.Name;
                old.Comment = newProduct.Comment;
                _context.SaveChangesAsync();

        }

        /// <summary>
        /// Добавление товара
        /// </summary>
        /// <param name="product"></param>
        /// <exception cref="Exception"></exception>
        public void AddProduct(Product product)
        {
            using (var cintext = new Context()) { 
            if (cintext.Product.Any(x => x.Name == product.Name && x.Price == product.Price))
                throw new Exception("Товар с таким наименоованием и ценной существует");
            else
            {
                cintext.Product.Add(product);
                cintext.SaveChanges();
            }
        }

        }
        /// <summary>
        /// Удаление товараSqlException: Не удалось вставить значение NULL в столбец "Articl", таблицы "DBDiplom2.dbo.Product"; в столбце запрещены значения NULL. Ошибка в INSERT.
        /// </summary>
        /// <param name="product"></param>
        public void RemoveProduct (Product product) {

                var remove = _context.Product.Where(x => x.Name == product.Name && x.Price == product.Price).FirstOrDefault();
                _context.Remove(remove);
                _context.SaveChanges();

        }
    }

}
