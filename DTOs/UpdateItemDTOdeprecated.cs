using System.ComponentModel.DataAnnotations;

namespace Catalog.Api.DTOs
{
    public record UpdateItemDTOdeprecated
    {
        public string Name { get; init; }
        [Range(1, 1000)]
        public decimal Price { get; init; }
    }
}