using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernWebStore.Domain.Entities
{
    public class Product
    {
        public Product(string title, string description,
           decimal price, int quantityOnHand, int category)
        {
            this.Title = title;
            this.Description = description;
            this.Price = price;
            this.QuantityOnHand = quantityOnHand;
            this.CategoryId = category;

        }


        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int QuantityOnHand { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }


    }
       
    
}
