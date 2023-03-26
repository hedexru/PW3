namespace PW3_4
{
    internal class Program
    {
        class MyIntList
        {
            private List<int> numbersList = new List<int>();

            public double Average
            {
                get
                {
                    return CalculateAverage();
                }
            }

            public void AddNumber(int number)
            {
                numbersList.Add(TranslateNumber());
            }

            public void RemoveNumber(int number)
            {
                numbersList.Remove(number);
            }


            public double CalculateAverage()
            {
                int sum = 0;
                foreach (int number in numbersList)
                {
                    sum += number;
                }
                Console.WriteLine(sum/(double)numbersList.Count);
                return sum / (double)numbersList.Count;
            }
            public int TranslateNumber()
            {
                int number = Convert.ToInt32(Console.ReadLine());
                return number;
            }
        }
        static void Main(string[] args)
        {
            MyIntList myIntList = new MyIntList();
            myIntList.AddNumber(myIntList.TranslateNumber());
            myIntList.AddNumber(myIntList.TranslateNumber());
            myIntList.AddNumber(myIntList.TranslateNumber());
            myIntList.CalculateAverage();
        }
    }
}
