using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2ProgTemplate
{
    public class Customer
    {
        public string Name { get; private set; }

        private string Password { get; set; }

        private List<Product> _cart;
        public List<Product> Cart { get { return _cart; } }

        public Customer(string name, string password)
        {
            Name = name;
            Password = password;
            _cart = new List<Product>();
        }

        public bool CheckPassword(string password)
        {
            return false;
        }

        public void AddToCart(Product product)
        {

        }

        public void RemoveFromCart(Product product) 
        {
            
        }
        
        public double CartTotal()
        {
            return 0;
        }
    }
}
