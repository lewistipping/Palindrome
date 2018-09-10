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
                    String reverseWord ="";
                    for(int i = charArr.Length -1;i > -1 ;i--)
                    {
                        
                        reverseWord += charArr[i];
                    }
                    if(word.Replace(" ","") == reverseWord.Replace(" ", ""))
                    {
                        Console.WriteLine("It's a Palindrome");
                    }
                    
                }
                

            }
            
        }
    }
}
