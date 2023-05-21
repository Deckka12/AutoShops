using AutoShops.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShops.Repositories
{

    public class ClientRepositories
    {
        /// <summary>
        /// Поиск клиента
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Clients Search (Clients client) {
            using(var context = new Context())
            {
                return context.Client.Where(x => x.Name == client.Name && x.FirstName == client.FirstName && x.Phone == client.Phone).FirstOrDefault();
            }
        }

        /// <summary>
        /// Поиск клиента
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Clients SearchEmailAndPhone (string Email, string Prhone) {
            using(var context = new Context())
            {
                return context.Client.Where(x => x.Email == Email && x.Phone == Prhone).FirstOrDefault();
            }
        }

        /// <summary>
        /// Добавление клиента
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        public Clients AddClient (Clients client) {
            using(var db = new Context())
            {
                var add = new Clients
                {
                    Name = client.Name,
                    FirstName = client.FirstName,
                    MiddleName = client.MiddleName,
                    Phone = client.Phone,
                    Addres = client.Addres,
                    Email = client.Email
                };
                db.Client.Add(add);
                db.SaveChangesAsync();
                return add;
            }

        }
        public void RemoveClient (Clients client) {
            using(var db = new Context())
            {
                var cl = db.Client.FirstOrDefault(x=>x.Email==client.Email && x.Phone ==client.Phone);
                db.Client.Remove(cl);
                db.SaveChanges();
            }
        }

        public void EditClient(Clients oldClient,Clients NewClients) {
            using(var db = new Context())
            {
                var client = db.Client.FirstOrDefault(x => x.Email == oldClient.Email && x.Phone == oldClient.Phone);
                if(client != null)
                { 
                    client.FirstName = NewClients.FirstName;
                    client.MiddleName = NewClients.MiddleName;
                    client.Phone = NewClients.Phone;
                    client.Addres = NewClients.Addres;
                    client.Email = NewClients.Email;
                    db.SaveChanges();
                }
            }
        }
        public List<Clients> ShowClient () {
            using(var db = new Context())
            {
                return db.Client.ToList();
            }
        }
    }
}
