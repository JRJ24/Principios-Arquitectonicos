
//Aplicamos el YAGNI
public class ProductService{
    public void AddProduct(string productName, decimal price){
        System.Console.WriteLine($"Product {productName} added with price {price}");
    }

    public void RemoveProduct(string productName){
        System.Console.WriteLine($"Product {productName} removed");
    }
}

public class Program{
    public static void Main(string[] args){
        ProductService productService = new ProductService();

        System.Console.WriteLine("1. Agregar producto");
        System.Console.WriteLine("2. Eliminar producto");

        int option = Convert.ToInt32(Console.ReadLine());
        switch(option){
            case 1:
                System.Console.WriteLine("Ingrese el nombre del producto: ");
                string productName = Console.ReadLine();
                System.Console.WriteLine("Ingrese el precio del producto: ");
                decimal price = Convert.ToDecimal(Console.ReadLine());
                productService.AddProduct(productName, price);
                break;
            case 2:
                System.Console.WriteLine("Ingrese el nombre del producto a eliminar: ");
                string productNameToRemove = Console.ReadLine();
                productService.RemoveProduct(productNameToRemove);
                break;
        }
    }
}