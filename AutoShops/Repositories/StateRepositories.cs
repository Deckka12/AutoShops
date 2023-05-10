using AutoShops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.Repositories
{
    public class StateRepositories
    {
        /// <summary>
        /// Вывод состояния
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public StateOrder viewState(string name) {
            using(var _context = new Context())
                return ContextRun.Context().StateOrder.Where(x => x.Name.Equals(name)).FirstOrDefault();
        }
    }
}
