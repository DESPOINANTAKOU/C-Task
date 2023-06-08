using System;
using System.Diagnostics.CodeAnalysis;

namespace C_Task.tier1_question1
{
    public class Class1
    {
        static void Main()
        {

            //we ask for a string and we save it in variable inputWord
            Console.Write("Enter a string: ");

            string? inputWord = Console.ReadLine();

            if (inputWord != null && inputWord != "")
            {
                //this is the count variable that counts the times that f character appeared inside the word
                int count = 0;


                //foreach parses the inputWord and splits it into its characters that in each loop  saves in c variable
                foreach (char currentCharacter in inputWord)
                {

                    //if the current character is letter f, we add +1 at the count variable's value.
                    if (currentCharacter == 'f')
                    {
                        count++;
                    }
                }
            }
        }
    }
}