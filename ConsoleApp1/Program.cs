namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour >= 11 && DateTime.Now.Hour <= 14)
            {
                Console.WriteLine(" Time for lunch !");
            }

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            int count = 5;
            while (count >= 1)
            {
                Console.WriteLine(count);
                count--;
            }


            string[] weeklySchedule = new string[7]

                {"Monday", "Tuesday" , "Wednesday","Thursday", "Friday", "Saturday","Sunday" };

            foreach (string day in weeklySchedule)
            {
                Console.WriteLine(day);
            }

            int[] Array1 = { 1, 2, 3, 4, 5 };
            int sum = 0;

            foreach (int number in Array1)
            {
                sum += number;
            }

            Console.WriteLine("The sum is: " + sum);
        }
    }
}
