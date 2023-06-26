using Domain.Models;
using Infrastructure.Services;

string? stop = null;
var calc = new CalcDemo();
var calcService = new CalcDemoService();

while (true)
{
    if(stop == "Quit" || stop == "quit") { break; }

    Console.Write("The first number is: ");
    calc.FirstNumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("The operation is: ");
    var operation = Convert.ToChar(Console.ReadLine());

    Console.Write("The second number is: ");
    calc.SecondNum = Convert.ToInt32(Console.ReadLine());

    switch (operation)
    {
        case '+':
        {
                Console.WriteLine($"{calc.FirstNumber} - {calc.SecondNum} = {calcService.GetSubtraction(calc)}");
                break;
        }
        case '-':
        {
                Console.WriteLine($"{calc.FirstNumber} - {calc.SecondNum} = {calcService.GetSubtraction(calc)}");
                break;
        }
        case '*':
        {
                Console.WriteLine($"{calc.FirstNumber} * {calc.SecondNum} = {calcService.GetMultiplication(calc)}");
                break;
        }
        case '/':
        {
                Console.WriteLine($"{calc.FirstNumber} / {calc.SecondNum} = {calcService.GetDivision(calc)}");
                break;
        }
        default:
        {
            Console.WriteLine("Wrong Input!");
            break;
        }
    }

    Console.Write("Write 'Quit' or 'quit' to exit program or '-' to continue: ");
    stop = Console.ReadLine();
}