using System;

namespace intermediateExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //==============================EXCERCISE 1=============================//

            /*            Console.WriteLine(Blackjack(21, 46));
                        Console.WriteLine(Blackjack(20, 19));
                        Console.WriteLine(Blackjack(12, 5));
                        Console.WriteLine(Blackjack(20, 123));
                        Console.WriteLine(Blackjack(50, 21));
                        Console.WriteLine(Blackjack(21, 21));*/

            //==============================EXCERCISE 2=============================//
            //SALARY CALCULATOR
            TaxCalculator();
         




        }



        //-------Methods below:
        //--Method for EX1

        //.Blackjack: Create a method that accepts two integer values greater than 0.
        //If both values are greater than 21 or both are less than 1, return 0.
        //If the values are within the range of 1 - 21(inclusive), return whichever is closest to 21 without going over 21.
        /*        public static int Blackjack(int num1, int num2)
                {
                    int a = num1;
                    int b = num2;

                    if (a > 21 || a < 0 )
                    {
                        if (b > 21 || b < 0)
                        {
                            return 0;
                        } else
                        {
                            return b;
                        }
                    } else if (b > 21 || b < 0)
                    {
                        if (a > 21 || a < 0)
                        {
                            return 0;
                        } else
                        {
                            return a;
                        }
                    } else if (a <= 21 && b <= 21)
                    {
                        return Math.Max(a, b);
                    } else
                    {
                        return a;
                    }


                }*/

        //-----------------this was my failed code....
        ///*     public static int Blackjack(int num1, int num2)
        //     {
        //         int a = num1;
        //         int b = num2;
        //          if (a > 21 && b > 21)
        //         {
        //             return 0;
        //         } else if (a < 1 && b < 1)
        //         {
        //             return 0;
        //         } else if (a > 21 && b <= 21)
        //         {
        //             if (b <= 21)
        //             {
        //                 return b;
        //             } else
        //             {
        //                 return 0;
        //             }

        //         } else if (b > 21 && a <= 21)
        //         {
        //             if (a <=21)
        //             {
        //                 return a;
        //             } else
        //             {
        //                 return 0;
        //             }

        //         } else if (a <=21 && b <= 21)
        //         {
        //             return Math.Max(a, b);
        //         } else if (a == b)
        //         {
        //             return a;
        //         }

        //     }*/

        //--Method for EX2
        //2.	Taxes:
        //a)	Create a method that takes a salary as input and returns the percentage by which the salary will be taxed.
        //b)  Create a second method that works out the amount a user will be taxed and returns the amount of tax to be taken from the salary.
        //c)	If the method from part b does not use the method from part a, make it use it.
        //-	Tax amounts:
        //	0 - 14,999 : 0% tax
        //	15,000 - 19,999 : 10% tax
        //	20,000 - 29,999 : 15% tax
        //	30,000 - 44,999 : 20% tax
        //	45,000+ : 25% tax



        public static void TaxCalculator()
        {
            Console.WriteLine("Please enter your Yearly Salary:");
            string input = Console.ReadLine();
            int salary = Convert.ToInt32(input);
            int taxRate = TaxPercent(salary); 
            Console.WriteLine($"Your yearly salary is {input}, and your tax rate is {taxRate} %");
            Console.WriteLine($"Your salary after tax is: {salary - (salary / 100 * taxRate)}");
        }

        public static int TaxPercent(int taxInput)
        {
            if (taxInput <= 14_999)
            {
                return 0;
            }
            else if (taxInput <= 15_000)
            {
                return 10;
            }
            else if (taxInput <= 19_999)
            {
                return 15;
            }
            else if (taxInput <= 29_999)
            {
                return 20;
            }
            else if (taxInput <= 44_999)
            {
                return 20;
            }
            else
            {
                return 25;
            }
        }











    }
}
