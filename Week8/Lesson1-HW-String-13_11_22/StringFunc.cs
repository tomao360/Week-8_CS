using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8.Lesson1_HW_13_11_22
{
    internal class StringFunc
    {
        static void Main_2(string[] args)
        {
            string str1, str2;
            str1 = "Hello World";
            str2 = "Hello";

            //.Contains() -> Returns a value indicating whether a specified substring occurs within this string. Return -> It returns boolean value either true or false.
            //If the specified substring is found in this string, it returns true otherwise false.
            Console.WriteLine(str1.Contains(str2));
            //Will return => True

            //.CopyTo() -> Copies a specified number of characters from the specified position in the string. It copies the characters of this string into a char array.
            //From which index to start, the array that gets the string, which index to copy to , how many characters to copy.
            char[] arr = new char[10];
            str1.CopyTo(6, arr, 0, 5);
            Console.WriteLine(arr);
            //Will return => World

            //.Insert() -> Insert() method is used to insert the specified string at specified index number. The index number starts from 0. After inserting the specified string, it returns a new modified string.
            string str3 = str1.Insert(6, "Tamara's ");
            Console.WriteLine(str3);
            //Will return => Hello Tamara's World

            //.PadRight() -> PadRight() method is used to get a new string that left-aligns the characters in this string by padding them with spaces on the right, for a specified total length. (The padding number needs to be longer than the string length).
            str3 = str1.PadRight(30);
            Console.WriteLine(str3 + "Hi");
            //Will return => Hello World                   Hi

            //.Replace() -> Replace() method is used to get a new string in which all occurrences of a specified Unicode character in this string are replaced with another specified Unicode character. There are two methods of Replace() method. You can replace string also.
            //public string Replace(Char first, Char second)
            //public string Replace(String firstString, String secondString)
            str3 = str1.Replace('l', 't'); 
            Console.WriteLine(str3);
            //Will return => Hetto Wortd

            //.SubString() -> SubString() method is used to get a substring from a String. The substring starts at a specified character position and continues to the end of the string.
            str3 = str1.Substring(0, 4);
            Console.WriteLine(str3);
            //Will return => Hell

            //.ToCharArray() -> ToCharArray() method is used to get character array from a string object. It returns a character array.
            char[] arr1 = str1.ToCharArray();
            Console.WriteLine(arr1);
            //Will return => Hello World

            //.Split() -> Split() method is used to split a string into substrings on the basis of characters in an array. It returns an array whose elements contain the substrings from this instance that are delimited by one or more characters in separator.
            string[] arr2 = str1.Split('o');
            Console.WriteLine(arr2[1]);
            //Will return =>  W

            //.Trim() -> Trim() method is used to remove all leading and trailing white-space characters from the current String object. It returns a string.
            //public string Trim()
            //public string Trim(params Char[])
            //First method does not take any parameter. Second method takes a char array as parameter.
            str3 = str1.Trim('r','l', 'd');
            Console.WriteLine(str3);
            //Will return => Hello Wo

            //.TrimStart() -> TrimStart() method id used to remove all leading occurrences of a set of characters specified in an array from the current String object. It returns a string.
            str3 = str1.TrimStart('H', 'e', 'l');
            Console.WriteLine(str3);
            //Will return => o World

            //.StartWith() -> startsWith() method is used to check whether the beginning of this string instance matches the specified string. It returns boolean value.
            Console.WriteLine(str1.StartsWith(str2));
            //Will return => True

            //.IndexOf() -> IndexOf() is used to get index of the specified character present in the string. It returns the zero-based index position of value if that character is found, or -1 if it is not.
            int numIndex = str1.IndexOf('l');
            Console.WriteLine(numIndex);
            //Will return => 2



            //Exercise => Write a function that accepts a string and a substring. Each occurrence of the substring must be replaced with *.
            void switchString(string str, string substring)
            {
                string result;

                if (str.Contains(substring))
                {
                    result = str.Replace(substring, "*");
                    Console.WriteLine(result);
                }
            }

            switchString("Hello World", "ll");

        }
    }
}
