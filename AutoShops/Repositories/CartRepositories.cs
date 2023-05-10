﻿using AutoShops.Forms;
using AutoShops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.Repositories
{
    public class CartRepositories
    {
        
        public CartRepositories () {
            
        }
        /// <summary>
        /// Вывод категории
        /// </summary>
        /// <param name="account"></param>
        public List<Cart> ShowCart () {
            using(var _context = new Context())
            {
                return _context.Cart.ToList();
            }
        }
        /// <summary>
        /// Добавить товар
        /// </summary>
        /// <param name="product"></param>
        /// <param name="state"></param>
        public async void AddCart ( Product product, bool state) {
            using(var _context = new Context())
            {
                if(_context.Cart.Any(x => x.ProductIdProduct == product.IdProduct))
                {
                    var cart = _context.Cart.Where(x => x.ProductIdProduct == product.IdProduct);
                    cart.FirstOrDefault().Count += 1;
                    cart.FirstOrDefault().CostOrder += product.Price;
                    cart.FirstOrDefault().IsNotCountShop = state;
                   await _context.SaveChangesAsync();
                }
                else
                {
                    var cart = new Cart
                    {
                        ProductIdProduct = product.IdProduct,
                        Count = 1,
                        CostOrder = product.Price,
                        IsNotCountShop = state
                    };
                    _context.Cart.Add(cart);
                   await _context.SaveChangesAsync();
                }
            }
        }
        /// <summary>
        /// Увеличичть количество товара
        /// </summary>
        /// <param name="product"></param>
        /// <param name="count"></param>
        /// <param name="state"></param>
        public async void PlusCount ( Product product, int count, bool state) {
            using(var _context = new Context())
            {
                var cart = _context.Cart.Where(x => x.ProductIdProduct == product.IdProduct);
                cart.FirstOrDefault().Count += count;
                cart.FirstOrDefault().CostOrder += product.Price * count;
                cart.FirstOrDefault().IsNotCountShop = state;
               await _context.SaveChangesAsync();
            }
        }
        /// <summary>
        /// Очистить корзину на н-элемнтов
        /// </summary>
        /// <param name="product"></param>
        /// <param name="count"></param>
        public async void RemoveCart ( Product product, int count) {
            using(var _context = new Context())
            {
                var cart = _context.Cart.Where(x => x.ProductIdProduct == product.IdProduct);
                if(count == 0 || count == null)
                {
                    _context.Cart.Remove(cart.FirstOrDefault());
                }
                else
                {
                    cart.FirstOrDefault().Count -= count;
                }
                await _context.SaveChangesAsync();
            }
        }
        /// <summary>
        /// Полностью очистить корзину
        /// </summary>
        public async void FullRemoveCart () {
            using(var _context = new Context())
            {
                var cart = _context.Cart.ToList();
                int count = cart.Count;
                for(int i = 0; i < count; i++)
                {
                   _context.Cart.Remove(cart[i]);
                     _context.SaveChanges();
                }
                
            }
        }
    }
}
