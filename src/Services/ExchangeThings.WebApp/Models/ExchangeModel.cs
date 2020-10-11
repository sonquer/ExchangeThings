using System.ComponentModel.DataAnnotations;

namespace ExchangeThings.WebApp.Models
{
    public class ExchangeModel
    {
        [Required(ErrorMessage = "Name is empty")]
        public string Name { get; set; }
    }
}
