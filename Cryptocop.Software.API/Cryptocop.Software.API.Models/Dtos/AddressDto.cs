namespace Cryptocop.Software.API.Models.Dtos
{
    public class AddressDto
    {
        public int Id { get; set; }

        public string ProductIdentifier { get; set; }

        public float Quantity { get; set; }

        public float UnitPrice { get; set; }

        public float TotalPrice { get; set; }
    }
}