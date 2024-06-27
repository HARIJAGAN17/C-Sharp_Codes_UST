namespace ProductApi.Model
{
    public class Product
    {
        public Guid Id { get; } = Guid.NewGuid();

        public string Name { get; set; }

        public string Description { get; set; }

        public int Amount { get; set; }
    }
}
