using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace NumericalAnalysis1
{

    class Driver
    {
        static void Main(string[] args)
        {

            //Make sure endpoints have opposite signs.
            if (GetFunctionValue(1) * GetFunctionValue(2) > 0)
            {
                Console.WriteLine("function values have same sign therefore there is no solution");
                Console.WriteLine("The function evaluated at a is: " + GetFunctionValue(1));
                Console.WriteLine("The function evaluated at b is: " + GetFunctionValue(2));
            }
            else
            {
                Console.WriteLine("The function evaluated at a is: " + GetFunctionValue(1));
                Console.WriteLine("The function evaluated at b is: " + GetFunctionValue(2));
                Console.WriteLine("The function evaluated at both end points has opposite signs therefore the I.V.T holds true");
                Console.WriteLine("\n" + "\n");
                Console.WriteLine(BiSectionAlgorithm(1, 2, .00001, 17));
            }
            Console.Read();

        }//END MAIN

        public static double BiSectionAlgorithm(double a, double b, double tolerance, int numberIterations)
        {
            string[,] stringversion = new string[numberIterations + 1, 5];
            double p = 0;
            int count = 1;

            stringversion[0, 0] = "N";
            stringversion[0, 1] = "a";
            stringversion[0, 2] = "b";
            stringversion[0, 3] = "p";
            stringversion[0, 4] = "f(p)";

            for (int i = 1; i <= numberIterations + 1; i++)
            {
                p = (a + b) / 2;

                stringversion[i, 0] = count++ + "";
                stringversion[i, 1] = a.ToString();
                stringversion[i, 2] = b.ToString();
                stringversion[i, 3] = p.ToString();
                stringversion[i, 4] = GetFunctionValue(p).ToString();


                if (Math.Abs(GetFunctionValue(p)) < tolerance || ((b - a) / 2) < tolerance)
                {

                    break;
                }

                if (GetFunctionValue(a) * GetFunctionValue(p) > 0)
                {

                    a = p;
                }
                else
                {

                    b = p;
                }

            }//end for

            //This prints the matrix in a nice format.
            for (int i = 0; i < stringversion.GetLength(0); i++)
            {
                for (int j = 0; j < stringversion.GetLength(1); j++)
                {
                    Console.Write(stringversion[i, j].PadRight(16) + "       ");
                }
                Console.WriteLine("\n");
            }

            //Check if algorithm failed.
            if (GetFunctionValue(p) > tolerance)
            {
                Console.WriteLine("Method failed after" + " " + numberIterations + " " + "iterations, procedure completed unsuccessfully");
                return -1;
            }
            else
            {
                Console.WriteLine();
                Console.Write("The approximation of the solution to our function is: ");
                return p;
            }

        }//end bisection method algorithm

        //Specify the function in this method.
        public static double GetFunctionValue(double x)
        {
            //returns function value
            return Math.Pow(x, 3) + Math.Pow(x, 2) * 4 - 10;
        }
    }
}
    


