// Task 3 

Console.WriteLine("Enter a number");
string userInput = Console.ReadLine();


int parsedNumber;

if (int.TryParse(userInput, out parsedNumber))
{
    Console.WriteLine("The number you entered is: " + parsedNumber);

    // sum up the digits
    int sum = 0;
    string numberString = parsedNumber.ToString();
    for (int i = 0; i < numberString.Length; i++)
    {
        int num;
        if (int.TryParse(numberString[i].ToString(), out num))
        {
            sum += num;
        }
    }
    Console.WriteLine("The sum of the digits is: " + sum);
}
else
{
    Console.WriteLine("Failed to parse input as an integer");
}