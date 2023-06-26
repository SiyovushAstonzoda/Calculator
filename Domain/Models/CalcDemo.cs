namespace Domain.Models;
public class CalcDemo
{
    public double FirstNumber { get; set; }
    public double SecondNum { get; set; }

    public CalcDemo()
    {
        
    }

    public CalcDemo(double firstNum, double secondNum)
    {
        this.FirstNumber = firstNum;
        this.SecondNum = secondNum;
    }
}