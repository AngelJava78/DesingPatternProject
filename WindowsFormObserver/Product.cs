using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormObserver
{
    public class Product : ISubjectProduct
    {
        public List<IUserObserver> Users { get; private set; }
        private decimal price;
        public Product()
        {
            Users = new List<IUserObserver>();
        }
        public string Name { get; set; }
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value; 
                Notify();
            }
        }
        public override string ToString()
        {
            return $"Name: {Name}. Price: {Price.ToString("c")}";
        }
        public void Add(IUserObserver user)
        {
            if(Users.Contains(user))
            {
                throw new Exception("The user is already subscribed");
            }
            Users.Add(user);

        }

        public void Remove(IUserObserver user)
        {
            if(!Users.Contains(user))
            {
                throw new Exception("The user is not subscribed");
            }
            Users.Remove(user);
        }

        public void Notify()
        {
            foreach(var user in Users)
            {
                user.Update(this);
            }
            Form1 f = (Form1)Application.OpenForms[0];
            if(!Users.Any())
            {
                f.Notify($"There is no subscribed user");
            }
            f.Notify($"---------------------");
        }

    }
}
