using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities
{
    internal class Product
    {
        public int  Id { get; private set; }    

        public string Name { get; private set; }

        public int Description { get; private set; }

        public int Price { get; private set; }

        public int Stock { get; private set; }

        public int Image { get; private set; }

        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Ivalid name. Nmae is required");
        }

        public int CategoryId { get; set; }

        public Category Category { get; set; }  
    }
}
