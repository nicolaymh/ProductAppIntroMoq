

namespace ProductAppIntroMoq
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products;

        public ProductService()
        {
            _products = new List<Product>
           {
               new() { Id = 1, Name = "Laptop" },
               new() { Id = 2, Name = "Mobile" },
           };
        }

        public Product? GetProductById(int id)
        {
            try
            {
                if (id < 0)
                {
                    throw new ArgumentException("ID cannot be negative");
                }

                var productFound = _products.FirstOrDefault(p => p.Id == id);

                if (productFound == null)
                {
                    throw new ProductNotFoundException("Product not found");
                }

                return productFound;
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }

            catch (ProductNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

                return null;
            }

        }
    }
}
