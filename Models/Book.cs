using System.ComponentModel.DataAnnotations;

namespace BookMVC.Models
{

    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        /*
        public Book(int id, string name, string decription, decimal price)
        {
            Id = id;
            Name = name;
            Description = decription;
            Price = price;
        }*/

    }

}