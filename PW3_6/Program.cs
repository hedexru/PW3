namespace PW3_6
{
    internal class Program
    {
        public class RandomNumbersGenerator
        {
            public int length;
            public Random random = new Random();
            public List<int> numbers = new List<int>();
            public double variance;
            public double standardDeviation;
            public int median;

            public RandomNumbersGenerator(int length)
            {
                this.length = 5;
                for (int i = 0; i < 5; i++)
                {
                    numbers.Add(random.Next(1,9));
                }
            }

            public double Variance ()
            {
                double average = numbers.Average();
                double sum = numbers.Sum(number => Math.Pow(number - average, 2));
                variance = sum / (length - 1);
                return variance;
            }

            public double StandardDeviation ()
            {
                standardDeviation = Math.Sqrt(variance);
                return standardDeviation;
            }

            public int Median ()
            {
                numbers.Sort();
                int middle = length / 2;
                median = (length % 2 != 0) ? numbers[middle] : (numbers[middle - 1] + numbers[middle]) / 2;
                return median;
            }
            public void ReturnValues()
            {
                Console.WriteLine(Variance());
                Console.WriteLine(StandardDeviation());
                Console.WriteLine(Median());
            }
        }
        static void Main(string[] args)
        {
            RandomNumbersGenerator a = new RandomNumbersGenerator(5);
            a.ReturnValues();
        }
    }
}
