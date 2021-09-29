using System;

namespace MethodExcercises
{
    class Program
    {
        static void Main(string[] args)
        {
 //======================EXCERCISE 1==========================//
            Console.WriteLine("int sums");
            Console.WriteLine(Add(123, 14));
            Console.WriteLine(Sub(123, 14)); 
            Console.WriteLine(Mult(123, 14));
            Console.WriteLine(Div(123, 14));
            Console.WriteLine();
            //======================EXCERCISE 2==========================//
            Console.WriteLine("double sums");
            Console.WriteLine(Add(123.00, 14.00));
            Console.WriteLine(Sub(123.00, 14.00));
            Console.WriteLine(Mult(123.00, 14.00));
            Console.WriteLine(Div(123.00, 14.00));
            Console.WriteLine();
            //======================EXCERCISE 3==========================//
            Console.WriteLine("divide by zero");
            Console.WriteLine(Div(123.00, 0.00));
            Console.WriteLine();
            //======================EXCERCISE 3==========================//
            Console.WriteLine("passing by reference");
            float f = 12.00F;
            Console.WriteLine(f);
            Console.WriteLine(MultiplyVar(ref f, 12.00F));
            Console.WriteLine(f);


        }

//--------------Methods here:
//----Method EX1
//Create methods for the following cases that take 2 numerical parameters as ints and returns the int result:
//Addition
//Subtraction
//Division
//Multiplication
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Div(int num1, int num2)
        {
            return num1 / num2;
        }

//----Method EX2
//Create overloaded methods for the methods from q1 that take doubles as input instead and returns a double.
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Mult(double num1, double num2)
        {
            return num1 * num2;
        }
//----Method EX3
//Add a conditional check to your division method(that uses doubles) that checks if the second parameter
//     (the divisor, number to be divided by) is equal to 0.
//- If it is, check that the calculation would result in a positive or negative number.Return either 
//    double.PositiveInfinity or double.NegativeInfinity
        public static double Div(double num1, double num2)
        {
            if (num2 == 0)
            {
                if (num1 >=0)
                {
                    return double.PositiveInfinity;
                } else
                {
                    return double.NegativeInfinity;
                }

            }
            else
            {
                return num1 / num2;
            }
           
        }
//----Method EX4
        //        Create a method called “MultiplyVar” that takes a `ref float` and `float` parameter(2 parameters)
        // - Multiply the parameters together and set the `ref float` variable equal to the result
        //Use the method
        //Once the method has been appropriately used, print out the variable that was passed 
        //            as a reference to verify that the variable outside of the method was actually modified
        public static float MultiplyVar(ref float flo1, float flo2)
        {
            float sum =  flo1 * flo2;
            flo1 = sum;
            return sum;
        }





    }
}
