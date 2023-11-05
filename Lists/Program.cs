using System.ComponentModel;
using System;


List<int> forEvenNumbers = new List <int>();
List<int> forOddNumbers = new List <int>();

Console.WriteLine("Please input a number");
string input = Console.ReadLine();


while (!string.IsNullOrEmpty(input))
{
    if (int.TryParse(input, out int intInput))
    {
        if (intInput % 2 == 0)
        {
            forEvenNumbers.Add(intInput);
        }
        else
        {
            forOddNumbers.Add(intInput);
        }
    }
    else
    {
        Console.WriteLine("Please enter only integer numbers.");
    }

     Console.WriteLine("Please input a number or press Enter to exit");
     input = Console.ReadLine();
}

Console.WriteLine("Even Numbers:");
for (int evenNumbers = 0; evenNumbers < forEvenNumbers.Count; evenNumbers++)
{
    Console.WriteLine(forEvenNumbers[evenNumbers]);
}

Console.WriteLine("Odd Numbers:");
for (int oddNumbers = 0; oddNumbers < forOddNumbers.Count; oddNumbers++)
{
    Console.WriteLine(forOddNumbers[oddNumbers]);
}
