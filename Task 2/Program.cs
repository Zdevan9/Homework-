//Task 2 

Console.WriteLine("Enter a string");
string userInput = Console.ReadLine();

string[] splittedString = userInput.Split(' ');

for(int i = 0; i < splittedString.Length; i++)
{
    Console.WriteLine(splittedString[i]);
}