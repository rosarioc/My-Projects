using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ConsoleApplication2
{
    
    class HomographyMatrix : Matrix
    {
        private string RotationType="ZYZE";
        
        public HomographyMatrix(string RotationType)
        { 
            Matrix Identity_Transform = new Matrix(4,4);
            Identity_Transform.SetIdentity();
            data = Identity_Transform.Data;
        }

        public HomographyMatrix(string RotationType, Matrix param)
        {
            data = param.Data;
        }

        public HomographyMatrix(string RotationType, double X, double Y, double Z, double Yaw, double Pitch, double Roll)
        {
            Yaw = Yaw * (Math.PI / 180);
            Pitch = Pitch * (Math.PI / 180);
            Roll = Roll * (Math.PI / 180);

            if (RotationType == "ZYZE")
            {
                data[0, 0] = (Math.Cos(Yaw) * Math.Cos(Pitch) * Math.Cos(Roll)) - (Math.Sin(Yaw) * Math.Sin(Roll));
                data[0, 1] = (-1 * Math.Cos(Yaw) * Math.Cos(Pitch) * Math.Sin(Roll)) - (Math.Sin(Yaw) * Math.Cos(Roll));
                data[0, 2] = Math.Cos(Yaw) * Math.Sin(Pitch);
                data[0, 3] = X;
                data[1, 0] = (Math.Sin(Yaw) * Math.Cos(Pitch) * Math.Cos(Roll)) + (Math.Cos(Yaw) * Math.Sin(Roll));
                data[1, 1] = (-1 * Math.Sin(Yaw) * Math.Cos(Pitch) * Math.Sin(Roll)) + (Math.Cos(Yaw) * Math.Cos(Roll));
                data[1, 2] = Math.Sin(Yaw) * Math.Sin(Pitch);
                data[1, 3] = Y;
                data[2, 0] = -1 * Math.Sin(Pitch) * Math.Cos(Roll);
                data[2, 1] = Math.Sin(Pitch) * Math.Sin(Roll);
                data[2, 2] = Math.Cos(Pitch);
                data[2, 3] = Z;
                data[3, 0] = 0; data[3, 1] = 0; data[3, 2] = 0; data[3, 3] = 1;

            }

            else if (RotationType == "XYZF")
            {
                data[0, 0] = Math.Cos(Roll) * Math.Cos(Pitch);
                data[0, 1] = (Math.Cos(Roll) * Math.Sin(Pitch) * Math.Sin(Yaw)) - (Math.Sin(Roll) * Math.Cos(Yaw));
                data[0, 2] = (Math.Cos(Roll) * Math.Sin(Pitch) * Math.Cos(Yaw)) + (Math.Sin(Roll) * Math.Sin(Yaw));
                data[0, 3] = X;
                data[1, 0] = Math.Sin(Roll) * Math.Cos(Pitch);
                data[1, 1] = (Math.Sin(Roll) * Math.Sin(Pitch) * Math.Sin(Roll)) + (Math.Cos(Roll) * Math.Cos(Yaw));
                data[1, 2] = (Math.Sin(Roll) * Math.Sin(Pitch) * Math.Cos(Yaw)) - (Math.Cos(Roll) * Math.Sin(Yaw));
                data[1, 3] = Y;
                data[2, 0] = (-1*Math.Sin(Pitch));
                data[2, 1] = Math.Cos(Pitch) * Math.Sin(Yaw);
                data[2, 2] = Math.Cos(Pitch) * Math.Cos(Yaw);
                data[2, 3] = Z;
                data[3, 0] = 0; data[3, 1] = 0; data[3, 2] = 0; data[3, 3] = 1;
            }

            else if (RotationType == "XYZE")
            {
                data[0, 0] = Math.Cos(Pitch) * Math.Cos(Yaw);
                data[0, 1] = -1*Math.Cos(Pitch) * Math.Sin(Yaw);
                data[0, 2] = Math.Sin(Pitch);
                data[0, 3] = X;
                data[1, 0] = (Math.Cos(Roll) * Math.Sin(Yaw)) + (Math.Sin(Roll) * Math.Sin(Pitch) * Math.Cos(Yaw));
                data[1, 1] = (Math.Cos(Roll) * Math.Cos(Yaw)) - (Math.Sin(Roll) * Math.Sin(Pitch) * Math.Sin(Yaw));
                data[1, 2] = -1*Math.Sin(Roll) * Math.Cos(Pitch);
                data[1, 3] = Y;
                data[2, 0] = (Math.Sin(Roll) * Math.Sin(Yaw)) - (Math.Cos(Roll) * Math.Sin(Pitch) * Math.Cos(Yaw));
                data[2, 1] = (Math.Sin(Roll) * Math.Cos(Yaw)) + (Math.Cos(Roll) * Math.Sin(Pitch) * Math.Sin(Yaw));
                data[2, 2] = Math.Cos(Roll) * Math.Cos(Pitch);
                data[2, 3] = Z;
                data[3, 0] = 0; data[3, 1] = 0; data[3, 2] = 0; data[3, 3] = 1;
            }

            else
                Console.WriteLine("You did not specify a valid rotation type, you get the zero matrix haha.");
         }

        public double getX()
        {
            return data[0, 3];
        }

        public double getY()
        {
            return data[1, 3];
        }

        public double getZ()
        {
            return data[2, 3];
        }

        public double getYaw()
        {
            double x = getPitch() * (Math.PI / 180);

            if (RotationType == "ZYZE")
            {
                if (getPitch() == 0 || getPitch() == 180)
                {
                    return 0;
                }
                else

                    return (Math.Atan2((data[1, 2] / Math.Sin(x)), (data[0, 2] / Math.Sin(x))) * (180 / Math.PI));
            }
            else if (RotationType == "XYZF")
            {
                if (getPitch() == 90 || getPitch() == -90)
                {
                    return 0;
                }
                else
                    return Math.Atan2((data[1, 0] / Math.Cos(x)), (data[0, 0] / Math.Cos(x)));
            }
            else if (RotationType == "XYZE")
            {
                if (getPitch() == 90 || getPitch() == -90)
                {
                    return 0;
                }
                else
                    return Math.Atan2(-1 * data[1, 2], data[2, 2]); 
            }
            return -1;//did not input correct data attribute for rotation type 
        }

        public double getPitch()
        {
            if (RotationType == "ZYZE")
            {
                return (Math.Atan2(Math.Sqrt(((data[2, 0] * data[2, 0]) + (data[2, 1] * data[2, 1]))), data[2, 2]) * (180 / Math.PI));
            }
            else if (RotationType == "XYZF")
            {
                return (Math.Atan2(-1 * data[2, 0], Math.Sqrt((data[0, 0] * data[0, 0]) + (data[1, 0] * data[1, 0]))) * (180 / Math.PI));
            }
            else if (RotationType == "XYZE")
            {
                return (Math.Atan2(-1 * data[0, 2], Math.Sqrt((data[1, 2] * data[1, 2]) + (data[2, 2] * data[2, 2]))) * (180 / Math.PI));
            }

            else return -1;//did not enter correct data attribute for rotation type

        }

        public double getRoll()
        {
            double x = getPitch() * (Math.PI / 180);

            if (RotationType == "ZYZE")
            {
                if (getPitch() == 0)
                {
                    return (Math.Atan2(-1 * data[0, 1], data[0, 0]) * (180 / Math.PI));
                }

                else if (getPitch() == 180)
                {
                    return (Math.Atan2(data[0, 1], -1 * data[0, 0]) * (180 / Math.PI));
                }
                else
                    return (Math.Atan2((data[2, 1] / Math.Sin(x)), (-1 * data[2, 0] / Math.Sin(x))) * (180 / Math.PI));
            }
            else if (RotationType == "XYZF")
            {
                if (getPitch() == 90)
                {
                    return (Math.Atan2(data[0, 1], data[1, 1]) * (180/Math.PI));
                }
                else if (getPitch() == -90)
                {
                    return (-1* Math.Atan2(data[0, 1], data[1, 1]) * (180/Math.PI));
                }
                else
                    return (Math.Atan2((data[2,1]/Math.Cos(x)), (data[0,0]/Math.Cos(x))) * (180/Math.PI));
            }
            else if (RotationType == "XYZE")
            {
                if (getPitch() == 90)
                {
                    return (Math.Atan2(data[1, 0], -1 * data[2, 0]) * (180 / Math.PI));
                }
                else if (getPitch() == -90)
                {
                    return (Math.Atan2(-1 * data[1, 0], data[2, 0]) * (180 / Math.PI));
                }
                else
                    return (Math.Atan2(-1 * data[0, 1], data[0, 0]) * (180 / Math.PI)); 
            }
            return -1; //did not enter correct data attribute for rotation type
        }

        //Print a matrix for testing purposes
        public void prints()
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
    }

//    class Test
//    {
//        static void Main(string[] args)
//        {
//            HomographyMatrix B = new HomographyMatrix("ZYZE",428.476,172.397,389.189,30.635,100.618,24.232);
//            HomographyMatrix T = new HomographyMatrix("ZYZE", 5, 20, -10, 20, 10, 5);
//            HomographyMatrix TB = new HomographyMatrix("ZYZE", T.Mul(B));
//            B.prints();
//            T.prints(); 
//            TB.prints();
//            Console.WriteLine(TB.getX());
//            Console.WriteLine(TB.getY());
//            Console.WriteLine(TB.getZ());
//            Console.WriteLine(TB.getYaw());
//            Console.WriteLine(TB.getPitch());
//            Console.WriteLine(TB.getRoll());



//            Console.Read();
//        }



//    }
}
