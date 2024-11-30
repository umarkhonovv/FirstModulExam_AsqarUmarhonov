namespace FirsModulsExam
{
    public class Program
    {
        //1-SAVOL

        public static int CounterOfEvenNumbers(List<int> numbers)
        {
            var count = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        //2-SAVOL

        public static bool AllElementsLength5(List<string> texts)
        {
            foreach (var text in texts)
            {
                if (text.Length < 6)
                {
                    return false;
                }
            }

            return true;
        }

        //3-SAVOL

        public static string First3Letters(string text)
        {
            var result = text.Substring(0, 3);

            return result;
        }

        //4-SAVOL

        public static bool StartWithPdp(string text)
        {
            var result = text.StartsWith("PDP");

            return result;
        }
        static void Main(string[] args)
        {
        }
    }
}
