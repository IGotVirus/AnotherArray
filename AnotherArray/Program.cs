// 9x9 array with the multiplication table

int[,] multiArr = new int[9,9];




//2D grid with rndom numbers

/*
int[,] numbers =
{
    {100,21,32,43,54},
    {60,70,80,900,10},
    {2,200,305,406,50900},
    {100,29,300,4,56},
    {15,25,3,400,50}
};

int big = 0;
int small = numbers[0,0];
int count = 0;

foreach (int i  in numbers)
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
        Console.WriteLine($"{big} big num");
        Console.WriteLine($"{small} this is small num");
    }
}
for(int a = 0; a < numbers.GetLength(0); a++)
{
    Console.WriteLine();
    for (int b = 0; b < numbers.GetLength(1); b++)
    {
   

        if(numbers[a, b] == small)
        {
            Console.WriteLine($"Small row = {a + 1}, Small col = {b + 1}");
        }
        if (numbers[a, b] == big)
        {
            Console.WriteLine($"Big row = {a + 1}, Big col = {b + 1}");
            break;
        }

    }
}

*/