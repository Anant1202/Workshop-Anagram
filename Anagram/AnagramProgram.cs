using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    public class AnagramProgram
    {
        public void AP()
        {
            Console.WriteLine("Enter string 1");
            string s1=Console.ReadLine();
            Console.WriteLine("Enter string 2");
            string s2 = Console.ReadLine();
            char[] arr1=s1.ToUpper().ToCharArray();
            char[] arr2 = s2.ToUpper().ToCharArray();
            Array.Sort(arr1);
            Array.Sort(arr2);
            string s3 = new string(arr1);
            string s4 = new string(arr2);
            if(s3==s4)
            {
                Console.WriteLine("It is an Anagram");
            }
            else
            {
                Console.WriteLine("It is not an Anagram");
            }
        }
    }
}
