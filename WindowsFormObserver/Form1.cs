using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormObserver
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void subscribeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = userListBox.SelectedItem as User;
                var product = productListBox.SelectedItem as Product;
                product.Add(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }

        private void unsubscribeButton_Click(object sender, EventArgs e)
        {
            try
            {
                var user = userListBox.SelectedItem as User;
                var product = productListBox.SelectedItem as Product;
                product.Remove(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var users = new List<User>
            {
                new User{ Name ="Angel", LastName ="Javier"},
                new User{ Name ="Zulidany", LastName ="Hernández"},
                new User{ Name ="Rubí", LastName ="Javier"},
            };
            userListBox.DataSource = users;
            userListBox.DisplayMember = "Name";
            userListBox.Refresh();

            var products = new List<Product>
            {
                new Product{ Name ="Apple MacBook Air", Price = 25999},
                new Product{ Name ="Laptop Dell Modelo Inspiron 15 3505", Price = 13499},
                new Product{ Name ="Computadora All In One HP 21-b0013la", Price = 10349},
            };
            productListBox.DataSource = products;
            productListBox.DisplayMember = "Name";
            productListBox.Refresh();
        }

        public void Notify(string message)
        {
            messagesTextBox.AppendText(message);
            messagesTextBox.AppendText(Environment.NewLine);
        }

        private void productListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var userList = new List<User>();
                var product = productListBox.SelectedItem as Product;

                foreach (IUserObserver u in product.Users)
                {
                    userList.Add(u as User);
                }
                subscriberListBox.DataSource = userList;
                subscriberListBox.DisplayMember = "Name";
                subscriberListBox.ValueMember = "Name";
                subscriberListBox.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void productListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var product = productListBox.SelectedItem as Product;

                string text = Microsoft.VisualBasic.Interaction.InputBox("Input new price", $"Product: {product.Name}", product.Price.ToString());
                var newPrice = decimal.Parse(text);
                product.Price = newPrice;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

        }
    }
}
