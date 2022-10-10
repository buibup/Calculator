namespace Calculator.Tests;
using Calculator.Domain;

public class CalculatorTest
{
    [Fact]
    public void Test_1_add_2_add_4_is_7()
    {
        var calculate = new Calculator("1 + 2 + 4");

        var result = calculate.Calculate();

        Assert.Equal(7, result);
    }

    [Fact]
    public void Test_10_add_20_add_40_is_70()
    {
        var calculate = new Calculator("10 + 20 + 40");

        var result = calculate.Calculate();

        Assert.Equal(70, result);
    }

    [Fact]
    public void Test_50_add_20_sub_40_is_30()
    {
        var calculate = new Calculator("50 + 20 - 40");

        var result = calculate.Calculate();

        Assert.Equal(30, result);
    }

    [Fact]
    public void Test_5_mul_20_div_10_is_10()
    {
        var calculate = new Calculator("5 * 20 / 10");

        var result = calculate.Calculate();

        Assert.Equal(10, result);
    }

    [Fact]
    public void Test_500_div_10_mul_2_is_100()
    {
        var calculate = new Calculator("500 / 10 * 2");

        var result = calculate.Calculate();

        Assert.Equal(100, result);
    }

    [Fact]
    public void Test_500_div_10_div_2_is_25()
    {
        var calculate = new Calculator("500 / 10 / 2");

        var result = calculate.Calculate();

        Assert.Equal(25, result);
    }

    [Fact]
    public void Test_500_mul_10_mul_2_is_10000()
    {
        var calculate = new Calculator("500 * 10 * 2");

        var result = calculate.Calculate();

        Assert.Equal(10_000, result);
    }

    [Fact]
    public void Test_9_add_9_mul_9_is_162()
    {
        var calculate = new Calculator("9 + 9 * 9");

        var result = calculate.Calculate();

        Assert.Equal(162, result);
    }

    [Fact]
    public void Test_90_div_9_sub_9_is_1()
    {
        var calculate = new Calculator("90 / 9 - 9");

        var result = calculate.Calculate();

        Assert.Equal(1, result);
    }

    [Fact]
    public void Test_9_sub_9_sub_9_is_minus_9()
    {
        var calculate = new Calculator("9 - 9 - 9");

        var result = calculate.Calculate();

        Assert.Equal(-9, result);
    }
}