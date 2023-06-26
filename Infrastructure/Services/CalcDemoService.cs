using Domain.Models;

namespace Infrastructure.Services;
public class CalcDemoService
{
    public double GetSum(CalcDemo calcDemo)
    {
        return calcDemo.FirstNumber + calcDemo.SecondNum;
    }

    public double GetSubtraction(CalcDemo calcDemo) 
    {
        return calcDemo.FirstNumber - calcDemo.SecondNum;
    }

    public double GetMultiplication(CalcDemo calcDemo) 
    {
        return calcDemo.FirstNumber * calcDemo.SecondNum;
    }

    public double GetDivision(CalcDemo calcDemo) 
    {
        return calcDemo.FirstNumber / calcDemo.SecondNum;
    }
}