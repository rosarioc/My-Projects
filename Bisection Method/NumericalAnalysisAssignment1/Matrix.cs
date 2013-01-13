//Author: Carlos Rosario
//Purpose : Create Matrix class and demo its several methods

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace NumericalAnalysis1
{
    class Matrix
    {
        private double[,] data = new double[4,4];
        private double[,] data2;
        public string[,] temp; 

        //Print a matrix
        public void print()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write( data[i, j] + "     ");
                }
                Console.WriteLine();
            }
        }

        public Matrix()
        { }

        //Dummy constructor only used by scale method and transpose method.
        public Matrix(int i, int j, int k)
        {
            data = new double[i, j];
        }

        //Create Matrix with i rows and j columns, also displays number of rows/columns as well as allows user to input matrix.
        public Matrix(int i, int j)
        {
            //data = new double[i, j];
            temp = new string[i,j];
            //Console.Write("there are" + " " + data.GetLength(0) +" " +"rows" );
            //Console.WriteLine();
            //Console.Write("there are" + " " + data.GetLength(1) +" " + "columns");
            //Console.WriteLine("\nPlease enter the elements of your desired matrix:");
            //for (int k = 0; k < data.GetLength(0); k++)
            //{
            //    for (int l = 0; l < data.GetLength(1); l++)
            //    {
            //        data[k, l] = int.Parse(Console.ReadLine());
            //    }
            //}
        }

        //Will Multiply a Matrix by "Multiply_By".
        public Matrix Mul (Matrix Multiply_By)
        {
            
            data2 = Multiply_By.Data;
            Matrix Product = new Matrix(data.GetLength(0), data2.GetLength(1));
            double[,] product = new double[data.GetLength(0), data2.GetLength(1)];

            if (data.GetLength(1) == data2.GetLength(0))
            {
                for (int i = 0; i < product.GetLength(0); i++)
                {
                    for (int j = 0; j < product.GetLength(1); j++)
                    {
                        product[i, j] = 0;
                        for (int k = 0; k < data.GetLength(1); k++)
                        {
                            product[i, j] += data[i, k] * data2[k, j];
                        }

                    }
                }
                Product.Data=product;
            }
            //If matrix multiplication is not defined prints error message.
            else

                Console.Write("Dimensions of two matrices do not agree, please try again");
            return Product;
        }

        //Will Add a matrix with "Add_By"
        public Matrix Add(Matrix Add_By)
        {
            data2 = Add_By.Data;
            double[,] sum = new double[data.GetLength(0), data.GetLength(1)];//Creates dimensions for the sum of the two matrices.

            if (data.GetLength(0) == data2.GetLength(0) && data.GetLength(1) == data2.GetLength(1))//Check dimensions before attemtping to add two matrices.
            {
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        sum[i, j] += data[i, j] + data2[i, j];
                    }
                }
                Add_By.Data = sum;

            }//If matrix dimensions do not allow matrix addition
            else
                Console.Write("Matrix dimensions do not allow matrix addition, please try again");
            return Add_By;
        }

        //Will Subtract a matrix by "Subtract_By"
        public Matrix Sub(Matrix Subtract_By)
        {
            data2 = Subtract_By.Data;
            double[,] difference = new double[data.GetLength(0), data.GetLength(1)];//Creates dimensions for "difference".

            if (data.GetLength(0) == data2.GetLength(0) && data.GetLength(1) == data2.GetLength(1))//checks to make sure that dimensions allow matrix subtraction.
            {
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        difference[i, j] += data[i, j] - data2[i, j];
                    }
                }
                Subtract_By.Data = difference;
               
            }//If dimensions do not allow matrix subtraction
            else
                Console.Write("Matrix dimensions do not agree for matrix subtraction, please try again");
            return Subtract_By;
        } 
        
        //Will multiply a matrix by a scalar "s".
        public Matrix scale(double s)
        {
            for(int i=0; i<data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = data[i, j] * s;
                }
            }
            Matrix scalar = new Matrix(data.GetLength(0), data.GetLength(1),0);
            scalar.Data = data; 
            return scalar;
        }

        //Transposes a matrix.
        public Matrix Transpose()
        {
            double[,] TransposeData = new double[data.GetLength(1), data.GetLength(0)];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    TransposeData[j, i] = data[i, j];
                }
            }
            Matrix Transpose = new Matrix(TransposeData.GetLength(0), TransposeData.GetLength(1), 0);
            Transpose.Data = TransposeData;

            return Transpose;
        }

        //Tests if two matrices are equal.
        public bool Equals(Matrix Test_equal)
        {
            data2 = Test_equal.Data;
            if (data.GetLength(0) != data2.GetLength(0) || data.GetLength(1) != data2.GetLength(1))//first check to see if dimensions match.
            {
                Console.Write("false");  return false;
            }
            else
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        if (data[i, j] != data2[i, j])
                        {

                            Console.Write("false"); return false;
                           
                        }
                    }

                } Console.Write("true"); return true;               
        }

        //Sets a matrix to the identity matrix
        public void SetIdentity()
        {
            for (int i = 0; i < data.GetLength(0); i++)
                for (int j = 0; j < data.GetLength(1); j++)
                    if (i == j)
                        data[i, j] = 1;//Essentially puts 1's on the main diagonal.
                    else
                        data[i, j] = 0;//Zero's everywhere else.
 
            //Prints identity matrix
            //for (int i = 0; i < data.GetLength(0); i++)
            //{
            //    for (int j = 0; j < data.GetLength(1); j++)
            //    {
            //        Console.Write(data[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

        }

        //Returns Minimum/Maximum value in a given matrix as well as their respective locations
        public void MinMax(out double x, out double y, out Point z, out Point w)
        {
            //Initialize minimum/maximum to be the very first entry in the matrix
            x = data[0, 0];
            y = data[0, 0];
            z = new Point(0, 0);
            w = new Point(0, 0); 

            //This part fetches the minimum value and its position
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    if (data[i, j] < x)
                    {
                        x = data[i, j];
                        z = new Point(i, j);
                    }
                }
            }
                    double a = x;
                    Point Temp = z;
                    Console.Write("This the location of the minimum value in the matrix" + " "  + Temp);
                    Console.WriteLine();
                    Console.Write("this is the minimum value in the matrix:" + " " + a);
                    Console.WriteLine();

                    //This part fetches the maximum and its location
                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        for (int j = 0; j < data.GetLength(1); j++)
                        {
                            if (data[i, j] > y)
                            {
                                y = data[i, j];
                                w = new Point(i, j); 
                            }
                        }
                    }

                    double b = y;
                    Point Temp2 = w;
                    Console.Write("This the location of the minimum value in the matrix" + " " + Temp2);
                    Console.WriteLine();
                    Console.Write("this is the maximum value in the matrix:" + " " + b);
                    Console.WriteLine();
        }

        //Gets/Sets individual values in the matrix
        public double[,] Data
        {
            get {return data;}

            set {data = value;}
        }
    }

//    class Driver
//    {
//        static void Main(string[] args)
//        {
//            double min;
//            double max;
//            Point min_loc = new Point();
//            Point max_loc = new Point();

////            //Creates Default_Matrix with given dimensions the matrix is empty
////            Matrix Default_Matrix = new Matrix(3, 3);
////            Matrix LOL = new Matrix(3, 3);
////            Console.WriteLine("The product of the two matrices is: ");
////            Default_Matrix.Mul(LOL).print();
////            //Console.WriteLine("The sum of the two matrices is: ");
////            //Default_Matrix.Add(LOL).print() ;
////            //Console.WriteLine("The difference of the two matrices is: ");
////            //Default_Matrix.Sub(LOL).print();
////            //Console.WriteLine("The matrix after multiplying by the scalar is: ");
////            //Default_Matrix.scale(4).print();
////            //Default_Matrix.Transpose().print();
////            //Default_Matrix.Equals(LOL);
////            Default_Matrix.SetIdentity();

////            //Default_Matrix.MinMax(out min, out max, out min_loc, out max_loc);
////            Default_Matrix.Mul(LOL).MinMax(out min, out max, out min_loc, out max_loc);
//            Console.Read();
//        }
//    }
}
