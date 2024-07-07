# ProductAppIntroMoq 🚀

Este proyecto es un ejemplo simple y pequeño diseñado para ayudar a entender cómo funcionan Moq y xUnit juntos en el contexto de pruebas unitarias en C#. La aplicación implementa un servicio básico de productos, maneja excepciones y realiza pruebas unitarias utilizando xUnit y Moq.

## ¿Qué es xUnit? 🧪

xUnit es un framework de pruebas unitarias para .NET. Permite a los desarrolladores escribir pruebas para su código y verificar que las funcionalidades se comporten como se espera. xUnit es una herramienta poderosa para asegurar la calidad y la estabilidad del código a lo largo del tiempo, y es conocido por su simplicidad y extensibilidad.

## ¿Qué es Moq? 🤖

Moq es una biblioteca de mocking para .NET que facilita la creación de objetos simulados (mocks) en pruebas unitarias. Permite a los desarrolladores simular el comportamiento de dependencias y verificar interacciones sin necesidad de instancias reales. Moq es ampliamente utilizado por su sintaxis fluida y capacidad de integrarse con frameworks de pruebas unitarias como xUnit.

## Estructura del Proyecto 📁

```plaintext
ProductAppIntroMoq/
├── IProductService.cs
├── Product.cs
├── ProductNotFoundException.cs
├── ProductService.cs
├── Program.cs
ProductAppIntroMoqTest/
├── ProductServiceTests.cs
```
## ProductAppIntroMoq: Contiene la lógica de negocio.

- IProductService.cs: Define la interfaz del servicio de productos con el método GetProductById. Este método se utiliza para obtener un producto por su ID.

- Product.cs: Clase que representa un producto con propiedades Id y Name. Esta clase es un modelo simple que contiene la información básica de un producto.

- ProductNotFoundException.cs: Excepción personalizada para manejar errores cuando un producto no es encontrado. Esta excepción se lanza cuando se intenta acceder a un producto que no existe en la lista.

- ProductService.cs: Implementa la interfaz IProductService y proporciona la lógica para obtener productos por ID. Contiene una lista de productos de ejemplo y maneja las excepciones necesarias.

- Program.cs: Punto de entrada de la aplicación donde se realizan ejemplos de uso del servicio de productos. Este archivo contiene el código para ejecutar y probar la funcionalidad del servicio de productos.

## ProductAppIntroMoqTest: Contiene las pruebas unitarias para el proyecto.

- ProductServiceTests.cs: Contiene pruebas unitarias para verificar la funcionalidad de ProductService utilizando xUnit y Moq. Las pruebas incluyen casos para verificar que un producto existente se retorne correctamente y que se manejen adecuadamente los casos donde el producto no existe.

## Requisitos 🛠️

- .NET SDK
- xUnit
- Moq

## Ejecución de la Aplicación 🏃‍♂️

Para compilar y ejecutar la aplicación, usa el siguiente comando en la terminal:

```sh
dotnet run --project ProductAppIntroMoq
```
## Ejecución de las Pruebas 🧪

Para ejecutar las pruebas, usa el siguiente comando en la terminal:

```sh
dotnet test
```



