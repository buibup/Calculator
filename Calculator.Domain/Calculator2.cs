namespace Calculator.Domain
{
    public class Calculator2
    {
        private string[] values;
        public Calculator2(string value)
        {
            values = value.Split(" ");
        }

        public int Calculate()
        {
            var result = 0;
            int? value1 = null;
            int? value2 = null;
            string? operator1 = null;
            var isResult = false;

            if (values.Length > 0)
            {
                for (var i = 0; i < values.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        // even is number
                        int.TryParse(values[i], out int _value);
                        if (i > 0)
                        {
                            value2 = _value;

                            if (isResult)
                            {
                                value1 = result;
                            }
                        }
                        else
                        {
                            value1 = _value;
                        }

                        if (value1 is not null && value2 is not null && operator1 is not null)
                        {
                            result = Calc(value1 ?? 0, value2 ?? 0, operator1);
                            isResult = true;
                        }
                    }
                    else
                    {
                        // odd is operator
                        operator1 = values[i];
                    }
                }
            }

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
}
