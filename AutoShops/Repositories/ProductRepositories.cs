﻿using AutoShops.DBL;
using AutoShops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.Repositories {
    public class ProductRepositories {
        Context context = new Context();
        public ProductRepositories() {

        }
        CategoryRepositories categoryRepositories = new CategoryRepositories(); 
        public List<Product> ShowOrders () {
            using(var _context = new Context())
                return _context.Product.ToList();
        }

        public List<Product> ShowOrdersCategory (string name) {
            using(var _context = new Context())
                return _context.Product.Where(x => x.IdCategory == categoryRepositories.ShowCategorID(name)).ToList();
        }
        public List<Product> ShowOrdersName ( string name) {
            using(var _context = new Context())
                return _context.Product.Where(x => x.Name.Contains(name)).ToList();
        }
        public Product ShowOrdersId (int ID) {
            using(var _context = new Context())
                return _context.Product.Where(x => x.IdProduct==ID).FirstOrDefault();
        }
        public Product ShowOrdersNameCount ( string name, int count) {
            using(var _context = new Context())
            {
                if(_context.Product.Where(x => x.Name.Contains(name) && x.Count >= count).Count() == 1)
                    return _context.Product.Where(x => x.Name.Contains(name)).FirstOrDefault();
                else
                    return null;
            }
                
        }
    }
   
}
