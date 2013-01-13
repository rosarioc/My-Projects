using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{

    class KinematicsRX60 : Matrix
    { 
        HomographyMatrix TEMP = new HomographyMatrix("ZYZE");
        HomographyMatrix T01 = new HomographyMatrix("ZYZE");
        HomographyMatrix T12 = new HomographyMatrix("ZYZE");
        HomographyMatrix T23 = new HomographyMatrix("ZYZE");
        HomographyMatrix T34 = new HomographyMatrix("ZYZE");
        HomographyMatrix T45 = new HomographyMatrix("ZYZE");
        HomographyMatrix T56 = new HomographyMatrix("ZYZE");

        public KinematicsRX60(double angle1, double angle2, double angle3, double angle4, double angle5, double angle6)
        {
            T01 = MakeFrame(0, 0 , 0 , angle1);
            T12 = MakeFrame(0, -90, 0, angle2);
            T23 = MakeFrame(290, 0, 49, angle3);
            T34 = MakeFrame(0, 90, 310, angle4);
            T45 = MakeFrame(0, -90, 0, angle5);
            T56 = MakeFrame(0, 90, 65, angle6);
        }

        private HomographyMatrix MakeFrame(double a, double alpha, double d, double theta)
        {
            HomographyMatrix Temp = new HomographyMatrix("ZYZE");
            alpha = alpha * (Math.PI / 180);
            theta = theta * (Math.PI/ 180);
           
                Temp.data[0, 0] = Math.Cos(theta);
                Temp.data[0, 1] = -1 * Math.Sin(theta);
                Temp.data[0, 2] = 0;
                Temp.data[0, 3] = a;
                Temp.data[1, 0] = Math.Sin(theta) * Math.Cos(alpha);
                Temp.data[1, 1] = Math.Cos(theta) * Math.Cos(alpha);
                Temp.data[1, 2] = -1 * Math.Sin(alpha);
                Temp.data[1, 3] = -1 * Math.Sin(alpha) * d;
                Temp.data[2, 0] = Math.Sin(theta) * Math.Sin(alpha);
                Temp.data[2, 1] = Math.Cos(theta) * Math.Sin(alpha);
                Temp.data[2, 2] = Math.Cos(alpha);
                Temp.data[2, 3] = Math.Cos(alpha) * d;
                Temp.data[3, 0] = 0;
                Temp.data[3, 1] = 0;
                Temp.data[3, 2] = 0;
                Temp.data[3, 3] = 1;

                
                return Temp;
            
        }

        public HomographyMatrix computeT06()
        {

            Matrix lol;
            lol = T01.Mul(T12);
            lol = lol.Mul(T23);
            lol = lol.Mul(T34);
            lol = lol.Mul(T45);
            lol = lol.Mul(T56);

            data = lol.Data;
            TEMP.Data = data;
            return TEMP;   
        }

        static void Main(string[] args)
        {
            
            KinematicsRX60 carlos = new KinematicsRX60(5,5,5,5,5,5);
            Console.WriteLine(carlos.computeT06().getYaw());
            Console.WriteLine(carlos.computeT06().getPitch());
            Console.WriteLine(carlos.computeT06().getRoll());
            Console.WriteLine();
            carlos.print();
            Console.Read();
            //note: i'm not 100% sure that the program is giving correct output, but at least the columns of the rotation part of the matrix all have magnitude 1 so i suspect that this program works the way we intended (didn't have any way to test results).

        }
    }
}
