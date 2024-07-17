using System.Drawing;
using System.Net.NetworkInformation;
using ClassLibrary1;

namespace Day6_OOP_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Point3D Task
            Point3D p = new Point3D(10, 10, 10);
            Console.WriteLine(p.ToString());
            string myStr = (string)p;
            Console.WriteLine(myStr);
            Console.WriteLine();


            // Duration Task
            Duration D1 = new Duration(3600);
            Console.WriteLine(D1);

            Duration D2 = new Duration(7800);
            Console.WriteLine(D2);

            Duration D3 = new Duration(666);
            Console.WriteLine(D3);

            D3 = D1 + D2;
            Console.WriteLine(D3);

            D3 = D1 + 7800;
            Console.WriteLine(D3);

            D3 = 666 + D3;
            Console.WriteLine(D3);

            D3 = D1++;
            Console.WriteLine(D3);

            D3 = --D2;
            Console.WriteLine(D3);

            if (D1 > D2)
                Console.WriteLine("D1 is greater than D2");
            else if (D1 <= D2)
                Console.WriteLine("D1 is less than or equal to D2");

            DateTime Obj = (DateTime)D1;
            Console.WriteLine(Obj);


        }
    }
}
