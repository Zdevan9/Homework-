// Bonus Task 

Console.WriteLine("Enter a sentence");
string userSentence = Console.ReadLine();

string[] splittedString = userSentence.Split(" ");
string largestWord = "";

foreach (string word in splittedString)
{
    if(word.Length > largestWord.Length)
    {
        largestWord = word;
    }
}
Console.WriteLine(largestWord);