using System.ComponentModel.DataAnnotations;
using MVCDemo.Models;


namespace MVCDemo.Models
{
    public class Pizza
    {
        public List<Pizza> pizzas = new();
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public PizzaSize Size { get; set; }
        public bool IsGlutenFree { get; set; }

        [Range(0.01, 9999.99)]
        public decimal Price { get; set; }

        public string GlutenFreeText(Pizza pizza)
        {
            return pizza.IsGlutenFree ? "Gluten Free" : "Not Gluten Free";
        }
    }
}
public enum PizzaSize { Small, Medium, Large }