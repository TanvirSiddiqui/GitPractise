using System;

namespace reverseString
{
    class Program
    {
        public void stringReverse(string str)
        {
            char[] chars = str.ToCharArray();
             for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                char c = chars[i];
                chars[i] = chars[j];
                chars[j] = c;
            }
            Console.WriteLine(chars);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int no_of_input=0;

            /*  string reversedString= p.stringReverse("Joy Bangla");

               Console.WriteLine(reversedString);*/

            no_of_input = int.Parse(Console.ReadLine());

            string[] word = new string[no_of_input];

            for(int i=0; i < no_of_input; i++)
            {
                word[i] = Console.ReadLine();
            }

            for (int i = 0; i < no_of_input; i++)
            {
                p.stringReverse(word[i]);
            }



        }
    }
}
