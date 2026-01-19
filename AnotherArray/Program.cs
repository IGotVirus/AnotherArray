// Nikita homework

namespace Program
{
    class HomeWork
    {
        enum WeekDays
        {

            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            bool firstChoice = false;

            int mainMenuInput;

            do

            {


                Console.WriteLine("Press 1 to display a 1 dimensional array.");
            Console.WriteLine("Press 2 to display a 2 dimensional array 9x9 with the multiplication table.");
            Console.WriteLine("Press 3 to display a 2 dimensional array with random numbers.");
            Console.WriteLine("Press 4 to display an Enum program.");
            Console.WriteLine();
            Console.Write("Enter the number of a program you want to see: ");
             mainMenuInput = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

           
                //1 dimensional array

                if (mainMenuInput == 1 && !firstChoice)
                {
                    firstChoice = true;

                    int[] nums = new int[10];

                    int sum = 0;

                    Random random = new Random();

                    for (int i = 0; i < nums.GetLength(0); i++)
                    {

                        nums[i] = random.Next(-10, 10);
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(nums[i]);
                        }

                    }

                    for (int f = 0; f < nums.GetLength(0); f++)
                    {

                        sum = nums[f] + sum;
                        nums[f] = sum;
                    }

                    if (sum > 0)
                    {
                        Console.WriteLine($"{sum} the sum of the elements in the array is a positive number.");
                    }
                    if (sum < 0)
                    {
                        Console.WriteLine($"{sum} the sum of the elements in the array is a negative number.");
                    }

                }


                //2 dimensional array 9x9 with the multiplication table

                if (mainMenuInput == 2 && !firstChoice)
                {
                    firstChoice = true;

                    int[,] multiArr = new int[9, 9];


                    for (int first = 0; first < multiArr.GetLength(0); first++)
                    {


                        for (int second = 0; second < multiArr.GetLength(1); second++)
                        {

                            multiArr[first, second] = (first + 1) * (second + 1);
                            Console.Write($"{multiArr[first, second]}\t");

                        }
                        Console.WriteLine();



                    }
                }

                //2 dimensional array with random numbers

                if (mainMenuInput == 3 && !firstChoice)
                {

                    firstChoice = true;

                    int[,] numbers =
                {
    {100,21,32,43,54},
    {60,70,80,900,10},
    {2,200,305,406,50900},
    {100,29,300,4,56},
    {15,25,3,400,50}
};

                    int big = 0;
                    int small = numbers[0, 0];
                    int count = 0;

                    foreach (int i in numbers)
                    {


                        if (big < i)
                        {
                            big = i;

                        }
                        if (small > i)
                        {
                            small = i;
                        }
                        count++;

                        if (count == numbers.Length)
                        {
                            Console.WriteLine($"{big} biggest number in the array.");
                            Console.WriteLine($"{small} this is the smallest number in the array.");
                        }
                    }
                    for (int a = 0; a < numbers.GetLength(0); a++)
                    {
                        Console.WriteLine();
                        for (int b = 0; b < numbers.GetLength(1); b++)
                        {


                            if (numbers[a, b] == small)
                            {
                                Console.WriteLine($"Smallest number row = {a + 1}, Smallest number column = {b + 1}");
                            }
                            if (numbers[a, b] == big)
                            {
                                Console.WriteLine($"Biggest number row = {a + 1}, Biggest number column = {b + 1}");
                                break;
                            }

                        }
                    }

                }

                // enum program

                if (mainMenuInput == 4 && !firstChoice)
                {
                    firstChoice = true;

                    Console.Write("Enter a number to find a day: ");
                    int max = Convert.ToInt32(Console.ReadLine());



                    WeekDays[] days = { WeekDays.Monday, WeekDays.Tuesday, WeekDays.Wednesday, WeekDays.Thursday, WeekDays.Friday, WeekDays.Saturday, WeekDays.Sunday };


                    for (int i = 0, j = 0; j <= max; j++, i++)
                    {
                        if (i > 6)
                        {
                            i = 0;
                        }
                        if (j == max)
                        {
                            Console.WriteLine(days[i]);
                        }

                    }
                }
                } while (!firstChoice || mainMenuInput < 1 || mainMenuInput > 4);
          

        }

    }

}


/*

enum WeekDays
{

Monday,
Tuesday,
Wednesday,
Thursday,
Friday,
Saturday,
Sunday
}
  //an Enum program




*/