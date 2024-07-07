using Moq;
using ProductAppIntroMoq;


namespace ProductAppIntroMoqTest
{
    public class ProductServiceTests
    {
        /// <summary>
        /// Enfoque con Moq: Verifica que el método GetProductById retorna un producto cuando el producto existe.
        /// </summary>
        [Fact]
        public void GetProductById_WhenProductExists_ReturnsProduct()
        {
            // Arrange
            var mockProductService = new Mock<IProductService>();
            var product = new Product { Id = 1, Name = "Test Product" };
            mockProductService.Setup(service => service.GetProductById(1)).Returns(product);

            // Act
            var result = mockProductService.Object.GetProductById(1);

            // Assert
            Assert.IsType<Product>(result);
            Assert.Equal(product, result);
            Assert.NotNull(result);
        }


        /// <summary>
        /// Enfoque con Moq: Verifica que el método GetProductById retorna null cuando el producto no existe.
        /// </summary>
        [Fact]
        public void GetProductById_WhenProductDoesNotExist_ReturnsNull()
        {
            // Arrange
            var mockProductService = new Mock<IProductService>();
            mockProductService.Setup(service => service.GetProductById(It.IsAny<int>())).Returns<int>(id => null);

            // Act
            var result = mockProductService.Object.GetProductById(3);

            // Assert
            Assert.Null(result);
        }

        /// <summary>
        /// Enfoque con Moq: Verifica que el método GetProductById lanza una ArgumentException y retorna null cuando se proporciona un ID negativo.
        /// </summary>
        [Fact]
        public void GetProductById_WhenIdIsNegative_ThrowsArgumentException_And_ReturnNull()
        {
            // Arrange: Crear un mock de IProductService y configurar el método GetProductById para que lance una ArgumentException.
            var mockProductService = new Mock<IProductService>();
            mockProductService.Setup(service => service.GetProductById(It.Is<int>(id => id < 0)))
                              .Throws(new ArgumentException("Invalid product ID"));

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Act: Llamar al método GetProductById con un ID inválido.
            Product? result = null;
            try
            {
                result = mockProductService.Object.GetProductById(-1);
            }
            catch (ArgumentException ex)
            {
                // Capturar la excepción y escribir el mensaje en la consola
                Console.WriteLine(ex.Message);
            }

            // Assert: Verificar que la salida contiene "Invalid product ID" y que el resultado es null.
            var output = stringWriter.ToString();
            Assert.Contains("Invalid product ID", output);
            Assert.Null(result);

        }

        /// <summary>
        /// Enfoque sin Moq: Verifica que el método GetProductById lanza una ProductNotFoundException y retorna null cuando el producto no existe.
        /// </summary>
        [Fact]
        public void GetProductById_WhenProductDoesNotExist_ThrowsProductNotFoundException_And_ReturnNull()
        {
            // Arrange: Crear una instancia de ProductService y un StringWriter para capturar la salida de la consola.
            var productService = new ProductService();
            var stringWriter = new StringWriter();

            // Act: Redirigir la salida de la consola al StringWriter y llamar al método GetProductById con un ID que no existe.
            Console.SetOut(stringWriter);
            var result = productService.GetProductById(10);

            // Assert: Verificar que la salida contiene "Product not found" y que el resultado es null.
            var output = stringWriter.ToString();
            Assert.Contains("Product not found", output);
            Assert.Null(result);
        }
    }
}


