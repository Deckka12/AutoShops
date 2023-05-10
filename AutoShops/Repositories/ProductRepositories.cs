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
        public ProductRepositories () {

        }
        CategoryRepositories categoryRepositories = new CategoryRepositories();
        /// <summary>
        /// Вывод товаров
        /// </summary>
        /// <returns></returns>
        public List<Product> ShowOrders () {
            using(var _context = new Context())
            {
    
                return _context.Product.Include(x=>x.Category).ToList();
            }
              
        }

        /// <summary>
        /// Вывод товаров по категории
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Product> ShowOrdersCategory (string name) {
            using(var _context = new Context())
                return _context.Product.Include(x => x.Category).Where(x => x.CategoryID == categoryRepositories.ShowCategorID(name)).ToList();
        }
        /// <summary>
        /// Вывод товара по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Product> ShowOrdersName (string name) {
            using(var _context = new Context())
                return _context.Product.Include(x => x.Category).Where(x => x.Name.Contains(name)).ToList();
        }
     
        /// <summary>
        /// Вывод количества опредленного товара
        /// </summary>
        /// <param name="name"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public Product ShowOrdersNameCount (string name, int count) {
            using(var _context = new Context())
            {
                if(_context.Product.Where(x => x.Name.Contains(name) && x.Count >= count).Count() == 1)
                    return _context.Product.Where(x => x.Name.Contains(name)).FirstOrDefault();
                else
                    return null;
            }

        }
        /// <summary>
        /// редактирование товара
        /// </summary>
        /// <param name="old"></param>
        /// <param name="newProduct"></param>
        public void EditProduct (Product old, Product newProduct) {
            using(var _context = new Context())
            {
                old = _context.Product.Where(x => x.Name == old.Name).FirstOrDefault();
                old.Price = newProduct.Price;
                old.CategoryID = newProduct.CategoryID;
                old.Name = newProduct.Name;
                old.Comment = newProduct.Comment;
                _context.SaveChangesAsync();
            }
        }

        /// <summary>
        /// Добавление товара
        /// </summary>
        /// <param name="product"></param>
        /// <exception cref="Exception"></exception>
        public void AddProduct (Product product) {
            using(var _context = new Context())
            {
                if(_context.Product.Any(x => x.Name == product.Name && x.Price == product.Price))
                    throw new Exception("Товар с таким наименоованием и ценной существует");
                else
                {
                    _context.Product.Add(product);
                    _context.SaveChangesAsync();
                }
            }
        }
        /// <summary>
        /// Удаление товара
        /// </summary>
        /// <param name="product"></param>
        public void RemoveProduct (Product product) {
            using(var _context = new Context())
            {
                var remove = _context.Product.Where(x => x.Name == product.Name && x.Price == product.Price).FirstOrDefault();
                _context.Remove(remove);
                _context.SaveChanges();
            }
        }
    }

}
