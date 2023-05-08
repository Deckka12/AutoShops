using AutoShops.Forms;
using AutoShops.Models;
using AutoShops.Repositories;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AutoShops {
    public partial class Main : Form {
        public Main () {
            InitializeComponent();
        }
        Context db = new Context ();
        AccountRepositories repository = new AccountRepositories ();  
        ProductRepositories ProductRepositories = new ProductRepositories ();
        private void Main_Load (object sender, EventArgs e) {

            //TestCategory(db);
            //Testproduct(db);
            //TestStorage(db);
        }
        public void TestStorage (Context db) {

            var category1 = new Storage { Count = 15,IDproduct = 1 };
            var category2 = new Storage { Count = 15, IDproduct = 6 };
            db.Storage.AddRange(category1, category2);
            db.SaveChangesAsync();

        }

        public void TestCategory (Context db) {
            
                var category1 = new Category { NameCategory = "Масла, смазки" };
                var category2 = new Category { NameCategory = "Фильтра" };
                var category3 = new Category { NameCategory = "Автозапчасти" };
                var category4 = new Category { NameCategory = "Шины" };
                var category5 = new Category { NameCategory = "Аксессуары" };
                var category6 = new Category { NameCategory = "АвтоЭлектроника" };
                db.Category.AddRange(category1, category2, category3, category4, category5, category6);
                db.SaveChanges();

        }
        public  async void Testproduct (Context db) {
            CategoryRepositories CategoryRepositories = new CategoryRepositories();
            var category1 = CategoryRepositories.ShowCategories();
            string filename = @"F:\д001.jpg";
            // получаем короткое имя файла для сохранения в бд
            string shortFileName = filename.Substring(filename.LastIndexOf('\\') + 1); // cats.jpg
                                                                                       // массив для хранения бинарных данных файла
            byte[] imageData;
            using(System.IO.FileStream fs = new System.IO.FileStream(filename, FileMode.Open))
            {
                imageData = new byte[fs.Length];
                fs.Read(imageData, 0, imageData.Length);
            }
            
                var product = new Product
                {
                    Name = "Масло Лукойл 5л",
                    Price = 560,
                    //CategoryID = category1[0],
                    IdCategory = category1[0].Id,
                    Image = imageData,
                    Count = 0,
                    Comment = "das"
                };
                var product1 = new Product
                {

                    Name = "Маслянный Фильтр Bosch",
                    Price = 260,
                    //CategoryID = category1[1]                    ,
                    IdCategory = category1[1].Id
                    ,
                    Comment = "das",
                    Count = 13,
                    Image = imageData,
                };
                var product2 = new Product
                {
                    Name = "Двигатель ваз 2114 16кл",
                    Price = 56000,
                    //CategoryID = category1[2]                    ,
                    IdCategory = category1[2].Id,
                    Comment = "das",
                    Count = 15,
                    Image = imageData,
                };
                var product3 = new Product
                {
                    Name = "Шина Bosh 15'",
                    Price = 3360,
                    //CategoryID = category1[3]                    ,
                    IdCategory = category1[3].Id,
                    Comment = "das",
                    Count = 100,
                    Image = imageData,
                };
                var product4 = new Product
                {

                    Name = "Вонючка с запахом ванили",
                    Price = 53,
                    //CategoryID = category1[4],
                    IdCategory = category1[4].Id,
                    Comment = "das",
                    Count = 250,
                    Image = imageData,
                };
                var product5 = new Product
                {
                    Name = "Автоколонки 16'",
                    Price = 3250,
                    //CategoryID = category1[5],
                    IdCategory = category1[5].Id,
                    Comment = "das",
                    Count = 0,
                    Image = imageData,
                };

                db.Product.AddRange(product1, product2, product3, product4, product5, product);
                await db.SaveChangesAsync();
            

        }

        private void Directory_Click (object sender, EventArgs e) {
            DialogResult dialogResult = MessageBox.Show("Хотите войти в режиме администратора?","Информация", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                InputUser cl = new InputUser();
                cl.ShowDialog();
                if(repository.CheckInput())
                {
                    Client clinet = new Client();
                    clinet.Show();
                }
            }
            else
            {
                Client client = new Client();
                client.ShowDialog();
            }
        }

        private void button3_Click (object sender, EventArgs e) {
            // Create a new instance of the form.
            Form form1 = new Form();
            
            Button button1 = new Button();
            Button button2 = new Button();

          
            button1.Text = "OK";
            button1.Location = new Point(10, 10);
            button2.Text = "Cancel";
            button2.Location
               = new Point(button1.Left, button1.Height + button1.Top + 10);
            form1.Text = "My Dialog Box";
            button1.Click += Directory_Click;

            // Add button1 to the form.
            form1.Controls.Add(button1);
            // Add button2 to the form.
            form1.Controls.Add(button2);

            // Display the form as a modal dialog box.
            form1.ShowDialog();


        }

        private void Main_FormClosed (object sender, FormClosedEventArgs e) {
            repository.OutputAccaunt();
        }
    }
}
