//Author: Carlos Rosario
//Purpose : Create Matrix class and demo its several methods

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ConsoleApplication1
{
    class Matrix
    {
        private double[,] data;
        private double[,] data2;
        
        //Create Matrix with i rows and j columns, also displays number of rows/columns as well as allows user to input matrix.
        public Matrix(int i, int j)
        {
            data = new double[i, j];
            Console.Write("there are this many rows:" + data.GetLength(0));
            Console.WriteLine();
            Console.Write("there are this many columns:" + data.GetLength(1));
            Console.WriteLine("\nEnter the elements of your desired matrix:");
            for (int k = 0; k < data.GetLength(0); k++)
            {
                for (int l = 0; l < data.GetLength(1); l++)
                {
                    data[k, l] = int.Parse(Console.ReadLine());
                }
            }
        }

        //Will Multiply a Matrix by "Multiply_By".
        public Matrix Mul (Matrix Multiply_By)
        {

            double[,] product = new double[data.GetLength(0), Multiply_By.GetLength(1)];//Creates dimensions for new matrix "product".
            if (data.GetLength(1) == Multiply_By.GetLength(0))//Checks dimensions to make sure that matrix multiplication is allowed.
            {
                for (int i = 0; i < product.GetLength(0); i++)
                {
                    for (int j = 0; j < product.GetLength(1); j++)
                    {
                        product[i, j] = 0;
                        for (int k = 0; k < data.GetLength(1); k++)
                        {
                            product[i, j] += data[i, k] * Multiply_By[k, j];
                        }

                    }
                }
                //Prints Matrix "product".
                for (int i = 0; i < product.GetLength(0); i++)
                {
                    for (int j = 0; j < product.GetLength(1); j++)
                    {
                        Console.Write(product[i, j] + " ");
                    }
                    Console.WriteLine();

                }
            }

            //If matrix multiplication is not defined prints error message.
            else

                Console.Write("Dimensions of two matrices do not agree, please try again");
            return product;
        }

        //Print a matrix
        public void print()
        {
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //Will Add a matrix with "Add_By"
        public double[,] Add(double[,] Add_By)
        {
            double[,] sum = new double[data.GetLength(0), data.GetLength(1)];//Creates dimensions for the sum of the two matrices.
            if (data.GetLength(0) == Add_By.GetLength(0) && data.GetLength(1) == Add_By.GetLength(1))//Check dimensions before attemtping to add two matrices.
            {
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        sum[i, j] += data[i, j] + Add_By[i, j];
                    }
                }
                //Prints matrix "sum". 
                for (int i = 0; i < sum.GetLength(0); i++)
                {
                    for (int j = 0; j < sum.GetLength(1); j++)
                    {
                        Console.Write(sum[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }//If matrix dimensions do not allow matrix addition
            else
                Console.Write("Matrix dimensions do not allow matrix addition, please try again");
            return sum;


        }

        //Will Subtract a matrix by "Subtract_By"
        public double[,] Sub(double[,] Subtract_By)
        {
            double[,] difference = new double[data.GetLength(0), data.GetLength(1)];//Creates dimensions for "difference".
            if (data.GetLength(0) == Subtract_By.GetLength(0) && data.GetLength(1) == Subtract_By.GetLength(1))//checks to make sure that dimensions allow matrix subtraction.
            {
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        difference[i, j] += data[i, j] - Subtract_By[i, j];
                    }
                }
                //Prints matrix "difference".
                for (int i = 0; i < difference.GetLength(0); i++)
                {
                    for (int j = 0; j < difference.GetLength(1); j++)
                    {
                        Console.Write(difference[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }//If dimensions do not allow matrix subtraction
            else
                Console.Write("Matrix dimensions do not agree for matrix subtraction, please try again");
            return difference;
        } 
        
        //Will multiply a matrix by a scalar "s".
        public double[,] scale(double s)
        {
            for(int i=0; i<data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = data[i, j] * s;
                }
            }
            //Prints Matrix multiplied by the scalar "s".
            for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        Console.Write(data[i, j] + " ");
                    }
                    Console.WriteLine();
                } return data;
        }

        //Transposes a matrix.
        public double[,] Transpose()
        {
            double[,] TransposeData = new double[data.GetLength(1), data.GetLength(0)];
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    TransposeData[j, i] = data[i, j];
                }
            }
            
            //Prints the transposed matrix
            for (int i = 0; i < TransposeData.GetLength(0); i++)
            {
                for (int j = 0; j < TransposeData.GetLength(1); j++)
                {
                    Console.Write(TransposeData[i, j] + " ");
                }
                Console.WriteLine();
                
            }return data;
        }

        //Tests if two matrices are equal.
        public bool Equals(double[,] Matrix5)
        {
            if (data.GetLength(0) != Matrix5.GetLength(0) || data.GetLength(1) != Matrix5.GetLength(1))//first check to see if dimensions match.
            {
                Console.Write("false"); return false;
            }
            else
                for (int i = 0; i < data.GetLength(0); i++)
                {
                    for (int j = 0; j < data.GetLength(1); j++)
                    {
                        if (data[i, j] != Matrix5[i, j])
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
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    Console.Write(data[i, j] + " ");
                }
                Console.WriteLine();
            }

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
        public double Data
        {
            get { 

                Console.WriteLine("\n Enter the row number of the element you are searching for");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("\n Enter the column number of the element you are searching for");
                int j = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("The value at this position in the array is: "); return data[i, j];
                

                 }
            set 
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter the row number of the element you want to update");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the column number of the element you want to update");
                int j = int.Parse(Console.ReadLine());
                data[i, j] = value;

            
            }
        }
    }
       
    class Driver
    {
        static void Main(string[] args)
        {
            //Creates Default_Matrix with given dimensions the matrix is empty
            
            Matrix Default_Matrix = new Matrix(2, 2);
            Console.WriteLine("Original Matrix:");
            Console.WriteLine();
            Default_Matrix.print();
            Console.WriteLine();
            double min; double max;
            Point min_loc = new Point();
            Point max_loc = new Point();

            ////Matrix to multiply,add,subtract, or test equals by.
            //double[,] Test_Matrix = { { 1, 2 }, { 1, 2 }};

            //Console.WriteLine("This is the Matrix after being multiplied by Test_Matrix:");
            //Console.WriteLine();
            //Default_Matrix.Mul(Test_Matrix);
            //Console.WriteLine();
            //Console.WriteLine("This is the Matrix after being multiplied by a scalar:");
            //Console.WriteLine();
            //Default_Matrix.scale(4);
            //Console.WriteLine();
            //Console.WriteLine("This is the Matrix that resulted from multiplying by the scalar and added to it is Test_Matrix:");
            //Console.WriteLine();
            //Default_Matrix.Add(Test_Matrix);
            //Console.WriteLine();
            //Console.WriteLine("This is the Matrix that resulted from multiplying by the scalar and then subtracting from it Test_Matrix:");
            //Console.WriteLine();
            //Default_Matrix.Sub(Test_Matrix);
            //Console.WriteLine();
            //Console.WriteLine("This is the Matrix transposed:");
            //Console.WriteLine();
            //Default_Matrix.Transpose();
            //Console.WriteLine();
            //Console.WriteLine("True or False: the matrices are equal?");
            //Console.WriteLine();
            //Default_Matrix.Equals(Test_Matrix);
            //Console.WriteLine();
            //Console.WriteLine("The current Matrix is reset to identity matrix:");
            //Console.WriteLine();
            //Default_Matrix.SetIdentity();
            //Console.WriteLine();
            //Default_Matrix.MinMax(out min, out max, out min_loc, out max_loc);
            //Console.WriteLine();
            //double j = Default_Matrix.Data;
            //Console.Write(j);
            //Default_Matrix.Data = 4;
            //Default_Matrix.print();

            Console.Read();










        }
    }
}
