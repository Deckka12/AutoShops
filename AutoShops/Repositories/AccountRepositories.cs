using AutoShops.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AutoShops.Repositories {
    public class AccountRepositories {
        Context _context = new Context();
        public AccountRepositories () {
            //_account = account;
        }
        /// <summary>
        /// Добавление нового пользователя
        /// </summary>
        /// <param name="account"></param>
        public void Add (Account account) {

                if(_context.Accounts.Any(x=>x.Name==account.Name && x.Login ==account.Login))
                {
                    throw new Exception($"Пользователь {account.Name} с логином {account.Login} уже зарегистрирован.");
                }
                var addUser = new Account { Name = account.Name, Login = account.Login, Password = account.Password, Administration = account.Administration };
                _context.Accounts.Add(addUser);
            _context.SaveChanges();

        }
        /// <summary>
        /// ВХод в аккаунт
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public Account InputAccaunt (string Login, string pass) {
               var account= _context.Accounts.Where(x => x.Login == Login && x.Password==pass).ToList();
                if(account.Count > 0)
                {
                    account.FirstOrDefault().IsLocked = true;
                    _context.SaveChanges();
                    return account.FirstOrDefault();
                }
                else
                    return null;
        }
        /// <summary>
        /// Выход в аккаунт
        /// </summary>
        /// <returns></returns>
        public void OutputAccaunt () {

                var account = _context.Accounts.Where(x => x.IsLocked == true).ToList();
                if(account.Count > 0)
                {
                    account.FirstOrDefault().IsLocked = false;
                    _context.SaveChanges();
                }

        }
        /// <summary>
        /// Проверка администратор или нет
        /// </summary>
        /// <returns></returns>
        public bool OutputAccauntIsAdmin () {

                var account = _context.Accounts.Where(x => x.IsLocked == true && x.Administration==true).ToList();
                if(account.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

        }

        /// <summary>
        /// Проверка входа
        /// </summary>
        /// <returns></returns>
        public bool CheckInput () {

                var account = _context.Accounts.Where(x => x.IsLocked == true).ToList();
                if(account.Count > 0)
                {
                    return true;
                }
                else
                    return false;

        }
        /// <summary>
        /// Удаления пользователя
        /// </summary>
        /// <param name="Login"></param>
        public void Delete (string Login) {
            using(var db = new Context()) {
                var users = _context.Accounts.FirstOrDefault(x => x.Login == Login);
                _context.Remove(users);
                _context.SaveChanges();
            }
        }
        /// <summary>
        /// Обновление данных аккаунта
        /// </summary>
        /// <param name="account"></param>
        public void Update (Account old,Account newAccount) {
                old = _context.Accounts.Where(x => x.Name == old.Name).FirstOrDefault();
                old.Name=newAccount.Name;
                old.Password = newAccount.Password;
                old.Login = newAccount.Login;
                old.Administration = newAccount.Administration;
                _context.SaveChangesAsync();
        }
        /// <summary>
        /// Обновление пароля
        /// </summary>
        /// <param name="newPass"></param>
        public void NewPass(string newPass,Account account) {
                account.Password = newPass;
                _context.SaveChanges();
        }
        /// <summary>
        /// Получить всех пользователей
        /// </summary>
        /// <returns></returns>
        public List<Account> GetAccounts () {

                return _context.Accounts.ToList();
        }
        /// <summary>
        /// Получить аккаунт по ФИО
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        public Account GetAccount(string Name) {

                return _context.Accounts.Where(x => x.Name == Name).FirstOrDefault();

        }
    }
}
