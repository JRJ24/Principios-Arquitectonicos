
// Aplicamos el principio SRP y el principio OCP
public class SendEmailService{
    public void SendEmail(string email, string message){
        System.Console.WriteLine($"Sending email to {email}: {message}");
    }
}

public class SendSmsService{
    public void SendSms(string phone, string message){
        System.Console.WriteLine($"Sending sms to {phone}: {message}");
    }
}

public class LogService{
    public void LogNotification(string message){
        System.Console.WriteLine($"Logging notification: {message}");
    }
}

public class Program{
    public static void Main(string[] args){
        SendEmailService emailService = new SendEmailService();
        SendSmsService smsService = new SendSmsService();
        LogService logService = new LogService();
        
        System.Console.WriteLine("1. Send email notification");
        System.Console.WriteLine("2. Send sms notification");
        int option = Convert.ToInt32(Console.ReadLine());
        switch(option){
            case 1:
                System.Console.Write("Enter email: ");
                string email = Console.ReadLine();
                System.Console.Write("Enter message: ");
                string message = Console.ReadLine();
                emailService.SendEmail(email, message);
                logService.LogNotification(message);
                break;
            case 2:
                System.Console.Write("Enter phone: ");
                string phone = Console.ReadLine();
                System.Console.Write("Enter message: ");
                string messageSms = Console.ReadLine();
                smsService.SendSms(phone, messageSms);
                logService.LogNotification(messageSms);
                break;
        }
    }
}