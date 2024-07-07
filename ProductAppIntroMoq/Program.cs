

using ProductAppIntroMoq;


IProductService productService = new ProductService();

// Intentar obtener un producto que existe
Console.WriteLine("Example Product found:");
Product? product = productService.GetProductById(2);
if (product != null)
{
    Console.WriteLine($"Producto: {product.Name}");
}

Console.WriteLine();

// Intentar obtener un producto que no existe
Console.WriteLine("Example Product not found:");
product = productService.GetProductById(3);
if (product == null)
{
    Console.WriteLine("The product does not exist");
}

