using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.Models {
    public class Account:IEntity {
        /// <summary>
        /// Ид сотудника
        /// </summary>
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// ФИО сотрудника
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Логин сотрудника
        /// </summary>
        public string Login { get; set; }
        /// <summary>
        /// Пароль сотрудника
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// Флаг вошел ли пользователь
        /// </summary>
        public bool IsLocked { get; set; }
        /// <summary>
        /// Флаг администратора
        /// </summary>
        public bool Administration { get; set; }


    }
}
