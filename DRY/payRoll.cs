public class payRoll{
    interface ISalaryCalculator{
        public decimal CalculateSalary(decimal salaryBase, int hourlyRated = 0, int hoursWorked = 0);
    }

    public class PayRollCalculator : ISalaryCalculator{
        public decimal CalculateSalary(decimal salaryBase, int hourlyRated = 0, int hoursWorked = 0){
            decimal salary = (hoursWorked > 0 && hourlyRated > 0) ? hourlyRated * hoursWorked : salaryBase;
            decimal tax = salary * 0.10m;
            decimal bonus = salary * 0.05m;
            return salary - tax + bonus;
        }
    }

    public class Program{
        public static void Main(string[] args){
            PayRollCalculator payRollCalculator = new PayRollCalculator();
            Console.WriteLine("1. Tiempo completo");
            Console.WriteLine("2. Medio tiempo");
            int option = Convert.ToInt32(Console.ReadLine());
            if(option == 1){
                Console.WriteLine(payRollCalculator.CalculateSalary(10000));
            }else if(option == 2){
                Console.WriteLine(payRollCalculator.CalculateSalary(10000, 20, 40));
            }
        }
    }
}