using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    internal sealed class Category
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public Category(string name)
        {
            ValidateDoamin(name);
        }

        public Category(int id,string name)
        {
            DomainExceptionValidation.When(id < 0, "Invalid Id value");
            Id = id;
            ValidateDoamin(name);
        }

        public void  Update (string name)
        {

        }

        public ICollection<Product> Products { get; private set; }  

        private void ValidateDoamin(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrWhiteSpace(name), "Invalid name.Name is required");

            DomainExceptionValidation.When(name.Length < 3, "Invalid name, Too short, minimum 3 characters");

            Name = name;
        }
    }
}
