using System.ComponentModel.DataAnnotations;

namespace ExchangeThings.WebApp.Models
{
    public class ExchangeModel
    {
        [Required(ErrorMessage = "Description is empty")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Name is empty")]
        public string Name { get; set; }

        public bool IsVisible { get; set; }
    }
}