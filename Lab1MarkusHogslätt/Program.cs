Console.Write("Enter a string with numbers and characters: ");

string inputString = Console.ReadLine();
    //"29535123p48723487597645723645";
int inputstringLenght = inputString.Length;
long sum = 0;
char[] chaStri = inputString.ToCharArray();

for (int i = 0; i < inputString.Length; i++)
{
    char firstCheck = inputString[i];
    

    for (int j = i + 1; j < inputString.Length; j++)
    {

        int lenght = inputString.Length - j-1;
        int x = j - i;
        char char2 = inputString[j];
        bool number = char.IsDigit(chaStri[j]);
        string stringBeforeMatch = inputString.Substring(0, i);
        string stringMatch = inputString.Substring(i, x + 1);
        string stringAfterMatch = inputString.Substring(j + 1, lenght);
        Console.ForegroundColor = ConsoleColor.Green;

        bool number2 = char.IsDigit(inputString[j]);

        if (number2 == false)
        {
            break;
        }



        if (char2 == firstCheck)
        {
            Console.Write(stringBeforeMatch);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(stringMatch);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(stringAfterMatch);
            j = inputString.Length;
            Console.WriteLine();
            long markedNumber = Convert.ToInt64(stringMatch);
            sum = sum + markedNumber;
        }


    }




}
Console.WriteLine();            
Console.WriteLine($"The total sum of all marked number is {sum}");

