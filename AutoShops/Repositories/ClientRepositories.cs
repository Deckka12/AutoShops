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
        public Clients Search (Clients client) {
            using(var context = new Context())
            {
                return context.Client.Where(x => x.Name == client.Name && x.FirstName == client.FirstName && x.Phone == client.Phone).FirstOrDefault();
            }
        }

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
    }
}
