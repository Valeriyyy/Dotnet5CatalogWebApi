using System;

namespace Catalog.Api.DTOs
{
    public record ItemDTOdeprecated
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}