using System;
using System.Linq;

namespace beginnerExcercises
{
    class Program
    {
        static void Main(string[] args)
        {   //=======================EXERCISE 1=================================//
            //.Create an integer array with at least 10 values
            //a.Iterate through the array with a for loop
            //b.Set each element in the array to its square and print it to the console

            /*                 int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

                            for (int i = 0; i < myArray.Length; i++)
                            {
                                Console.WriteLine(myArray[i]);
                            }

                            //squared:
                            for (int i = 0; i < myArray.Length; i++)
                            {   
                                myArray[i] = myArray[i] * myArray[i];
                                Console.WriteLine(myArray[i]);
                        }*/


            //=======================EXERCISE 2=================================//
            //. Using the array from q1:
            // a.Iterate through the array and print the following interpolated string to the console,
            // with the correct values inserted:
            // $“The square root of { element} is { squareRoot }”

            /*                for (int i = 0; i < myArray.Length; i++)
                            {
                                Console.WriteLine($"The square root of { myArray[i]} is { Math.Sqrt(myArray[i]) }");
                            }*/


            //=======================EXERCISE 3=================================//
            //.Create a method that prints out the numbers 1 - 10 10 times each
            //-The numbers 1 through 10 may all be printed on the same line, or printed on separate lines

            /*
                                for (int i = 1; i <= 10; i++)
                                {
                                    for (int j = 1; j <= 10; j++)
                                       {
                                            if (j == 10)
                                            {
                                                Console.WriteLine(j);
                                            } else
                                            {
                                                Console.Write(j); 
                                            }

                                       }
                                }*/

            //=======================EXERCISE 4=================================//
            //.Create a method that prints out the numbers 1 - 10 as many times as the value of that number, for example:
            //1
            //2, 2
            //3, 3, 3
            //4, 4, 4, 4
            //Etc…

            /*
            for (int i = 1; i <= 10; i++) 
            {
                for (int j = 0; j < i; j++)
                {
                    if (j == i - 1)
                    {
                        Console.Write(i);
                    } else
                    {
                        Console.Write(i + ",");
                    }

                }
                Console.WriteLine();
            }
*/
            //=======================EXERCISE 5=================================//
            //  .Create a method that accepts 3 parameters, two integers and 1 boolean.
            //- If the boolean is true, return the sum of the two numbers, else return the product of the two numbers.

            /*Console.WriteLine(BoolSum(false, 6, 7));*/


            //=======================EXERCISE 6=================================//
            //.Unique Sum.Create a method that accepts 3 integer values, return the sum of non - duplicate / unique values.For example:
            //-UniqueSum(1, 2, 3); // 6
            //-UniqueSum(3, 3, 3); // 0
            //-UniqueSum(1, 1, 2); // 2

            /*            Console.WriteLine(UniqueSum(1, 2, 3)); //6
                        Console.WriteLine(UniqueSum(3, 3, 3)); //3
                        Console.WriteLine(UniqueSum(1, 1, 2)); //3*/

            //=======================EXERCISE 7=================================//
            //.Create a method that takes a number between 10 and 99, and adds the two digits together.
            //Return - 1 if the number is outside the specified range. For example:
            //-AddDigits(11); // 2 as 1 + 1 = 2
            //-AddDigits(55); // 10 as 5 + 5 = 10
            //-AddDigits(8); // -1 as out of range

            Console.WriteLine(AddDigits(11));
            Console.WriteLine(AddDigits(55)); 
            Console.WriteLine(AddDigits(8)); 





}
//-------Methods below:

//--Method for EX5
/*        public static int BoolSum(bool boo1, int num1, int num2)
    {
        if (boo1 == true) {
            return num1 + num2;
        } else
        {
            return num1 * num2;
        }
    }*/

            //--Method for EX6
            /*        public static int UniqueSum(int num1, int num2, int num3)
                    {
                        int[] myArray = new int[3];
                        myArray[0] = num1;
                        myArray[1] = num2;
                        myArray[2] = num3;

                        var newArr = myArray.Distinct();

                        int sum = newArr.Sum();
                        return sum;
                    }*/

            //--Method for EX7
            public static int AddDigits(int num)
        {
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            } 
            return sum;
        }



    }
}
