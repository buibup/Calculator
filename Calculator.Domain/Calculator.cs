namespace Calculator.Domain;

public class Calculator
{
    private int value1;
    private int value2;
    private int value3;
    private string operator1;
    private string operator2;

    public Calculator(string calc)
    {
        var _value1 = calc.Split(" ")[0];
        int.TryParse(_value1, out value1);
        var _value2 = calc.Split(" ")[2];
        int.TryParse(_value2, out value2);
        var _value3 = calc.Split(" ")[4];
        int.TryParse(_value3, out value3);

        operator1 = calc.Split(" ")[1];
        operator2 = calc.Split(" ")[3];
    }

    public int Calculate()
    {
        var result = Calc(value1, value2, operator1);
        result = Calc(result, value3, operator2);

        return result;
    }

    private int Calc(int value1, int value2, string @operator)
    {
        var result = 0;
        if (@operator == "+")
        {
            result = value1 + value2;
        }
        else if (@operator == "-")
        {
            result = value1 - value2;
        }
        else if (@operator == "*")
        {
            result = value1 * value2;
        }
        else if (@operator == "/")
        {
            result = value1 / value2;
        }

        return result;
    }
}