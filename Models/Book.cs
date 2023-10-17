using System.ComponentModel.DataAnnotations;

namespace BookMVC.Models
{

    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatorio.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "A Descrição é obrigatoria.")]
        [MinLength(10, ErrorMessage ="A descrição deve ter no minimo 10 caracteres")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O Preço é obrigatorio.")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "O valor deve ser um número inteiro")]
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