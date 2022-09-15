namespace TTDDemo
{
    internal class Rooter
    {
        public double SquareRoot(double input)
        {
            double result = input;
            double previousResult = -input;
            while (Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = (result + input / result) / 2;
            }
            return result;
        }
    }
}