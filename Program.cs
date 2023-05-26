using System;

class Program
{   //Write a program that checks if 1st characters
    //are C and #
    static void Main(string[] args)
    {
        char char1, char2; //used to check characters of string
        string pos1, pos2; //assign to char1 and char2
        int numberOfInputs = 1;

        Console.WriteLine("Tell me some programming languages, and \nI'll check if any of them are C#.");
        Console.WriteLine("(Maximum of 10 inputs)");
        Console.WriteLine("How many inputs would you like to give?");

        numberOfInputs = Convert.ToInt32(Console.ReadLine()); //still needs Exception Handling!!
        string[] progLanguages = new string[numberOfInputs];

        for (int i = 0; i < numberOfInputs; i++)
        {
            //numberOfInputs = i;
            Console.Write("\n \nInput Language {0}:", i + 1);
            progLanguages[i] = Convert.ToString(Console.ReadLine());
        }

        Console.Write("\n\nAlright. Let's check to see if any languages\nare C#.");
        Console.Write("Press a key to continue...\n");

        for (int i = 0; i < numberOfInputs; i++)
        {
            pos1 = progLanguages[i].Substring(0, 1); 
            pos2 = progLanguages[i].Substring(1, 1);
            char1 = Convert.ToChar(pos1);
            char2 = Convert.ToChar(pos2);

            if (char1 == 'C' || char1 == 'c')
            {
                if (char2 == '#')
                {
                    Console.WriteLine("Input {0} is C#", i + 1);
                }
                
            }
            else
                {
                    Console.WriteLine("Input {0} is not C#", i + 1);
                }

        }
        Console.ReadKey();
    }
}