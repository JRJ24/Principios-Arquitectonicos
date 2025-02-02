public class RestauranteBill{
    // Aplicamos el KISS
    public decimal CalculateTotal(decimal[] prices, decimal? tipPercentage){
        decimal total = 0;
        
        foreach(decimal pricess in prices){
            total += pricess;
        }

        total += total * (tipPercentage.HasValue ? tipPercentage.Value / 100 : 0.10m);

        return total;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        decimal []prices = new decimal[3];
        RestauranteBill restauranteBill = new RestauranteBill();
        for (int i = 0; i <= prices.Length; i++)
        {
            Console.WriteLine("Ingrese el precio del platillo: ");
            prices[i] = Convert.ToDecimal(Console.ReadLine());
        }
        Console.WriteLine(restauranteBill.CalculateTotal(new decimal[] {prices[0], prices[1], prices[2]}, 10));
    }
}