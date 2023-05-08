using AutoShops.Models;
using AutoShops.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AutoShops.DBL
{
    public class InformationAccounts
    {
        AccountRepositories accountRepositories = new AccountRepositories();
        public bool IsAvailable {  get; private set ; }
        public InformationAccounts () {
            IsAvailable = accountRepositories.OutputAccauntIsAdmin();
        }
        
    }
}
