using System;
using System.Numerics;


namespace InfinitePrecisionCalculator
{
    public class BigNumber
    {
        public BigInteger IntegerPart { get; set; }
        public int Scale { get; set; }

        public BigNumber(BigInteger value, int scale)
        {
            IntegerPart = value;
            Scale = scale;
        }

        public static BigNumber Parse(string value)
        {
            value = value.Replace(",", ".");

            if (!value.Contains("."))
            {
                return new BigNumber(BigInteger.Parse(value), 0);
            }

            string[] parts = value.Split('.');

            string combined = parts[0] + parts[1];

            return new BigNumber(
                BigInteger.Parse(combined),
                parts[1].Length
            );
        }

        public override string ToString()
        {
            string str = BigInteger.Abs(IntegerPart).ToString();

            while (str.Length <= Scale)
            {
                str = "0" + str;
            }

            if (Scale > 0)
            {
                str = str.Insert(str.Length - Scale, ".");
            }

            if (IntegerPart < 0)
            {
                str = "-" + str;
            }

            return str;
        }

        private static void Normalize(ref BigNumber a, ref BigNumber b)
        {
            while (a.Scale < b.Scale)
            {
                a.IntegerPart *= 10;
                a.Scale++;
            }

            while (b.Scale < a.Scale)
            {
                b.IntegerPart *= 10;
                b.Scale++;
            }
        }

        public static BigNumber Add(BigNumber a, BigNumber b)
        {
            Normalize(ref a, ref b);

            return new BigNumber(
                a.IntegerPart + b.IntegerPart,
                a.Scale
            );
        }

        public static BigNumber Subtract(BigNumber a, BigNumber b)
        {
            Normalize(ref a, ref b);

            return new BigNumber(
                a.IntegerPart - b.IntegerPart,
                a.Scale
            );
        }

        public static BigNumber Multiply(BigNumber a, BigNumber b)
        {
            return new BigNumber(
                a.IntegerPart * b.IntegerPart,
                a.Scale + b.Scale
            );
        }

        public static BigNumber Divide(BigNumber a, BigNumber b, int precision = 20)
        {
            BigInteger multiplier = BigInteger.Pow(10, precision);

            BigInteger result =
                (a.IntegerPart * multiplier) / b.IntegerPart;

            return new BigNumber(
                result,
                precision + a.Scale - b.Scale
            );
        }
    }
}
