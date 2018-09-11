using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Enter a word/phrase to check if it is a Palindrome." +
                                    "\n Type \"Quit\" to exit)");
                String input = Console.ReadLine();

                if(input.ToLower() == "quit" )
                {
                    break;
                }
                else
                {
                    char[] charArr = input.ToCharArray();
                    String word = new String(charArr);
                    Console.WriteLine("Your word is "+word);
                    Array.Reverse(charArr);
                    String reverseWord = new string(charArr);
                    Console.WriteLine("Your word reversed is "+reverseWord);
                    
                    if(word.Replace(" ","") == reverseWord.Replace(" ", ""))
                    {
                        Console.WriteLine("It's a Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("It's not a Palindrome");
                    }
                    
                }
                

            }
            
        }
    }
}
