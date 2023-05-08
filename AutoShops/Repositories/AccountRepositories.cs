using AutoShops.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutoShops.Repositories {
    public class AccountRepositories {
        public AccountRepositories () {
            //_account = account;
        }
        /// <summary>
        /// Добавление нового пользователя
        /// </summary>
        /// <param name="account"></param>
        public void Add (Account account) {
            using(var addAccount = new Context()) {
                var addUser = new Account { Name = account.Name, Login = account.Login, Password = account.Password, Administration = account.Administration };
                addAccount.Accounts.Add(addUser);
                addAccount.SaveChanges();
            }
        }
        /// <summary>
        /// ВХод в аккаунт
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Account InputAccaunt (string Login, string pass) {
            using(var addAccount = new Context())
            {
               var account= addAccount.Accounts.Where(x => x.Login == Login && x.Password==pass).ToList();
                if(account.Count > 0)
                {
                    account.FirstOrDefault().IsLocked = true;
                    addAccount.SaveChanges();
                    return account.FirstOrDefault();
                }
                else
                    return null;
            }
        }
        /// <summary>
        /// Выход в аккаунт
        /// </summary>
        /// <returns></returns>
        public void OutputAccaunt () {
            using(var addAccount = new Context())
            {
                var account = addAccount.Accounts.Where(x => x.IsLocked == true).ToList();
                if(account.Count > 0)
                {
                    account.FirstOrDefault().IsLocked = false;
                    addAccount.SaveChanges();
                }
            }
        }
        public bool OutputAccauntIsAdmin () {
            using(var addAccount = new Context())
            {
                var account = addAccount.Accounts.Where(x => x.IsLocked == true && x.Administration==true).ToList();
                if(account.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// Проверка входа
        /// </summary>
        /// <returns></returns>
        public bool CheckInput () {
            using(var addAccount = new Context())
            {
                var account = addAccount.Accounts.Where(x => x.IsLocked == true).ToList();
                if(account.Count > 0)
                {
                    return true;
                }
                else
                    return false;

            }
        }
        /// <summary>
        /// Удаления пользователя
        /// </summary>
        /// <param name="Login"></param>
        public void Delete (string Login) {
            using(var db = new Context()) {
                var users = db.Accounts.FirstOrDefault(x => x.Login == Login);
                db.Remove(users);
                db.SaveChanges();
            }
        }
        /// <summary>
        /// Обновление данных аккаунта
        /// </summary>
        /// <param name="account"></param>
        public void Update (Account account) {
            
        }
        /// <summary>
        /// Обновление пароля
        /// </summary>
        /// <param name="newPass"></param>
        public void NewPass(string newPass,Account account) {
            using(var db = new Context()) {
                account.Password = newPass;
                db.SaveChanges();
            }
        }
    }
}
