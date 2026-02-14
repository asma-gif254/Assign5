namespace Assign5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter A Day Number (1-7) : ");
            //int input = int.Parse(Console.ReadLine());
            //DayOfWeek day = (DayOfWeek)input;
            //switch (day)
            //{
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("Saturday");
            //        Console.WriteLine("It's the Weekend");
            //        break;
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("Sunday");
            //        Console.WriteLine("It's a Workday");
            //        break;
            //    case DayOfWeek.Monday:
            //        Console.WriteLine("Monday");
            //        Console.WriteLine("It's a Workday");
            //        break;
            //    case DayOfWeek.Tuesday:
            //        Console.WriteLine("Tuesday");
            //        Console.WriteLine("It's a Workday");
            //        break;
            //    case DayOfWeek.Wednesday:
            //        Console.WriteLine("Wednesday");
            //        Console.WriteLine("It's a Workday");
            //        break;
            //    case DayOfWeek.Thursday:
            //        Console.WriteLine("Thursday");
            //        Console.WriteLine("It's a Workday");
            //        break;
            //    case DayOfWeek.Friday:
            //        Console.WriteLine("Friday");
            //        Console.WriteLine("It's the Weekend");
            //        break;
            //            default:
            //                Console.WriteLine("Enter valid work day");
            //                break;
            //        }


            //        double[,] grades = new double[3, 4];
            //        double totalSum = 0;

            //        for (int i = 0; i < 3; i++)
            //        {
            //            Console.WriteLine($"--- Enter grades for Student {i + 1} ---");
            //            for (int j = 0; j < 4; j++)
            //            {
            //                Console.Write($"Subject {j + 1}: ");
            //                grades[i, j] = double.Parse(Console.ReadLine());
            //            }
            //            Console.WriteLine();
            //        }

            //        for (int i = 0; i < 3; i++)
            //        {
            //            double studentSum = 0;
            //            for (int j = 0; j < 4; j++)
            //            {
            //                studentSum += grades[i, j];
            //            }

            //            double studentAverage = studentSum / 4;
            //            totalSum += studentSum;

            //            Console.WriteLine($"Student {i + 1} Average: {studentAverage:F2}");
            //        }
            //        double classAverage = totalSum / (3 * 4);
            //        Console.WriteLine($"Overall Class Average: {classAverage:F2}");
            //    }
            //}}

            Console.Write("Enter array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element [{i}]: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int max = numbers[0];
            int min = numbers[0];

            for (int i = 0; i < size; i++)
            {
                sum += numbers[i];
                if (numbers[i] > max) max = numbers[i];
                if (numbers[i] < min) min = numbers[i];
            }

            double average = (double)sum / size;

            Console.WriteLine($"\nSum      = {sum}");
            Console.WriteLine($"Average  = {average}");
            Console.WriteLine($"Max      = {max}");
            Console.WriteLine($"Min      = {min}");

            Console.Write("Reverse  = ");
            for (int i = size - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + (i == 0 ? "" : ", "));
            }
            Console.WriteLine();
        }
    }
}







