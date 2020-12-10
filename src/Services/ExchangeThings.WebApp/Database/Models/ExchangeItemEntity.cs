using System;

namespace ExchangeThings.WebApp.Database.Models
{
    public class ExchangeItemEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsVisible { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
