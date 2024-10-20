using System.Net;

class Calculator
{
    static void Main()
    {
    
    double firstvalue, secondvalue;
    string operatort;

     Console.WriteLine("Введите первое число");
     firstvalue = double.Parse(Console.ReadLine());

     Console.WriteLine("Введите второе число");
     secondvalue = double.Parse(Console.ReadLine());

     Console.WriteLine("Выберите оператора: + - * /");
     operatort = Console.ReadLine();

     switch (operatort)
     {
        case "+":
            Console.WriteLine(firstvalue + secondvalue);
            break;

        case "-":
            Console.WriteLine(firstvalue - secondvalue);
            break;

        case "*":
            Console.WriteLine(firstvalue * secondvalue);
            break;

         case "/":
            if (secondvalue != 0)
                {
                   Console.WriteLine(firstvalue / secondvalue);
                }
                else
                {
                    Console.WriteLine("Ошибка: деление на ноль");
                    
                }
                break;  

        default: 
            Console.WriteLine("Неизвестная команда");
            break;
     }

    }
}