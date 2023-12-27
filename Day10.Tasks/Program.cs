using System;

namespace Day10.Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(3.5, 4, 9)); // Task 1
            Console.WriteLine(SumOfElements(new int[] { 3, 5, 6 })); // Task 2
            Console.WriteLine(FindFirstIndex("Code Academy", 'a')); // Task 3
            Console.WriteLine(FindLastIndex("academy", 'a')); // Task 4
            Console.WriteLine(MaxNumber(new int[] { 6, 9, 8, 5 })); // Task 5
            Console.WriteLine(PositiveEven(-21)); // Task 6
            Console.WriteLine(CountPositiveEven(new int[] { 2, 6, -8, 3, 5, 4, -3 })); // Task 7
            Console.WriteLine(PositiveEvenArr(new int[] { 2, 7, 4, -9, 32, 11 })); // Task 8 
            Console.WriteLine(ReversedArr(new int[] { 33, 43, 45 }));  // Task 9
            Console.WriteLine(RemoveLeftSpace("  Code Academy  ")); // Task 10
            Console.WriteLine(RemoveRightSpace("PB302  ")); // Task 11
        }

        // 1. Verilmiş 3 ədədin cəmini tapan method(həm int, həm double ədədlər üçün)

        static int Sum(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        static double Sum(double num1, double num2, double num3)
        {
            return num1 + num2 + num3;
        }

        // 2. Verilmiş ədədlər siyahısındaki bütün ədədlərin cəmini tapan method (həm int, həm double ədədlər üçün)

        static int SumOfElements(int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }

        // 3. Verilmiş yazıda veirlmiş charın yerləşdiyi ilk indexi tapan method (yoxdursa -1 qaytarı)

        static int FindFirstIndex(string str, char wantedChar)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == wantedChar)
                {
                    return i;
                }
            }
            return -1;
        }

        // 4. Verilmiş yazıda verilmiş charın yerləşdiyi son indexi tapan method (yoxdursa -1 qaytarır)

        static int FindLastIndex(string str, char wantedChar)
        {
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] == wantedChar)
                {
                    return i;
                }
            }
            return -1;
        }

        // 5. Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan method

        static int MaxNumber(int[] nums)
        {
            int maxEded = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > maxEded)
                {
                    maxEded = nums[i];
                }
            }
            return maxEded;
        }

        // 6. Verilmiş ədədin müsbət və cüt olub olmadığını tapan method

        static bool PositiveEven(int num)
        {
            if (num > 0 && num % 2 == 0)
                return true;
            else
                return false;
        }

        // 7. Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərin sayını tapan method

        static int CountPositiveEven(int[] nums)
        {
            int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]>0 && nums[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        // 8. Verilmiş ədədlər siyahısındaki müsbət və cüt ədədlərdən ibarət yeni bir array düzəldən method.

        static int[] PositiveEvenArr(int[] nums)
        {
            int length = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 0)
                {
                    length++;
                }
            }
            int[] newArr = new int[length];
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0 && nums[i]%2 == 0)
                {
                    newArr[index] = nums[i];
                    index++;
                }
            }
            return newArr;
        }

        // 9. Verilmiş ədədlər siyahısından tərsinə düzülmüz yeni bir array qaytaran method.
        // (misalçün verilən arra {10,20,30} olarsa methoddan return olunan array {30,20,10} olacaq.

        static int[] ReversedArr(int[] nums)
        {
            int[] newNums = new int[nums.Length];
            
            for (int i = 0; i < nums.Length;i++)
            {
                newNums[i] = nums[nums.Length-1-i];
            }
            return newNums;
        }

        // 10. Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən method

        static string RemoveLeftSpace(string str)
        {
            int startIndex = 0;
            string newStr = "";
            for (int i = 0;i < str.Length; i++)
            {
                if (str[i] != ' ')
                {
                    startIndex = i;
                    break;
                }
            }
            for (int i = startIndex; i < str.Length; i++)
            {
                newStr += str[i];
            }
            return newStr;
        }

        // 11. Verilmiş yazıdan sonundaki boşluqlar silinmiş yeni string düzəldən method

        static string RemoveRightSpace(string str)
        {
            int lastIndex = str.Length - 1;
            string newStr = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (str[i] != ' ')
                {
                    lastIndex = i;
                    break;
                }
            }
            for (int i = 0; i < lastIndex+1; i++)
            {
                newStr += str[i];
            }
            return newStr;
            
        }
    }
}
