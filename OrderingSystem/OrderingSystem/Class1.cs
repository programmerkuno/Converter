using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderingSystem
{
    public class Class1
    {
        public void choice()
        {
            int choice;
            Console.WriteLine(" ---- Syntrax Pythagorean Theorem ---- ");
            Console.WriteLine();
            Console.WriteLine("1. Pythagorean Theorem");
            Console.WriteLine("2. Length");
            Console.WriteLine("3. Speed");
            Console.WriteLine("4. Area");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.Write("Enter Choice: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Clear();
                DisplayPythagorean();
            }
            else if (choice == 2)
            {
                Console.Clear();
                DisplayLength();
            } else if(choice == 3)
            {
                Console.Clear();
                displaySpeed();
            } else if(choice == 4)
            {
                Console.Clear();
                displayArea();
            } else if(choice == 5)
            {
                Console.ReadKey();
            }
        }

        public void DisplayPythagorean()
        {
            int a, b,aa,bb,ab,again;
            Console.WriteLine(" ---- Syntrax Pythagorean Theorem ---- ");
            Console.WriteLine();

            Console.Write("Enter value of A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter value of B: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            aa = a * a;
            bb = b * b;
            ab = aa + bb;
            double squareroot = Math.Sqrt(ab);
            Console.WriteLine("Formula: c² = a² + b²");
            Console.WriteLine("c² = " + a + "² " + "+ " + b + "²");
            Console.WriteLine("c² = " + aa + " + " + bb);
            Console.WriteLine("c² = " + ab);
            Console.WriteLine("c = √" + ab);
            Console.WriteLine("the value of c is " + squareroot);
            Console.Write("Again (1,0)?: ");
            again = int.Parse(Console.ReadLine());
            if(again == 1)
            {
                Console.Clear();
                DisplayPythagorean();
            } else if( again == 0)
            {
                Console.Clear();
                choice();
            }
        }

        public void DisplayLength()
        {
            int length,metre,cmetre,again;
            double length1, miles,yard,foot,inch;
            Console.WriteLine(" ---- Syntrax Length Converter ---- ");
            Console.WriteLine();

            Console.Write("Enter Kilometer: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            metre = length * 1000;
            cmetre = length * 100000;
            length1 = length;
            miles = convertDistance.ConvertKilometerstoMiles(length);
            yard = convertDistance.ConvertKilometerstoYard(length);
            foot = convertDistance.ConvertKilometerstoFoot(length);
            inch = convertDistance.ConvertKilometerstoInch(length);
            Console.WriteLine("Convert to Metre: " + metre);
            Console.WriteLine("Convert to Centimetre: " + cmetre);
            Console.WriteLine("Convert to Mile: " + miles);
            Console.WriteLine("Convert to Yard: " + yard);
            Console.WriteLine("Convert to Foot: " + foot);
            Console.WriteLine("Convert to Inch: " + inch);
            Console.Write("Again (1,0)?: ");
            again = int.Parse(Console.ReadLine());
            if (again == 1)
            {
                Console.Clear();
                DisplayLength();
            }
            else if (again == 0)
            {
                Console.Clear();
                choice();
            }
        }

        public void displaySpeed()
        {
            int metreperSecs,again;
            double metreperSecs1,miles,foot,metre;
            Console.WriteLine(" ---- Syntrax Speed Converter ---- ");
            Console.WriteLine();

            Console.Write("Enter Meter per Second: ");
            metreperSecs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            metreperSecs1 = metreperSecs;
            miles = convertSpeed.ConvertMilesPerKilometer(metreperSecs);
            foot = convertSpeed.ConvertMilesPerFoot(metreperSecs);
            metre = convertSpeed.ConvertMilesPerMetre(metreperSecs);
            Console.WriteLine("Kilometer Per Hour: " + miles);
            Console.WriteLine("Foot Per Second: " + foot);
            Console.WriteLine("Metre Per Second: " + metre);
            Console.Write("Again (1,0)?: ");
            again = int.Parse(Console.ReadLine());
            if (again == 1)
            {
                Console.Clear();
                displaySpeed();
            }
            else if (again == 0)
            {
                Console.Clear();
                choice();
            }
        }

        public void displayArea()
        {
            int area,kilometre,inch,hectare,again;
            double area1,mile,yard,foot,acre;
            Console.WriteLine(" ---- Syntrax Area Converter ---- ");
            Console.WriteLine();

            Console.Write("Enter Square Metre: ");
            area = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            area1 = area;
            kilometre = area * 1000000;
            inch = area * 1550;
            hectare = area * 10000;
            mile = convertArea.squaremile(area);
            yard = convertArea.squareyard(area);
            foot = convertArea.squarefoot(area);
            acre = convertArea.acrea(area);
            Console.WriteLine("Per Square Kilometre: " + kilometre);
            Console.WriteLine("Per Square Mile: " + mile);
            Console.WriteLine("Per Square Yard: " + yard);
            Console.WriteLine("Per Square Foot: " + foot);
            Console.WriteLine("Per Square Inch: " + inch);
            Console.WriteLine("Per Square Hectare: " + hectare);
            Console.WriteLine("Per Acre: " + acre);
            Console.Write("Again (1,0)?: ");
            again = int.Parse(Console.ReadLine());
            if (again == 1)
            {
                Console.Clear();
                displayArea();
            }
            else if (again == 0)
            {
                Console.Clear();
                choice();
            }
        }
    }

    public static class convertDistance
    {
        public static double ConvertKilometerstoMiles(double kilometers)
        {
            return kilometers * 0.621371192;
        }

        public static double ConvertKilometerstoYard(double yard)
        {
            return yard * 1093.61;
        }

        public static double ConvertKilometerstoFoot(double foot)
        {
            return foot * 3280.84;
        }

        public static double ConvertKilometerstoInch(double inch)
        {
            return inch * 39370.08;
        }
    }

    public static class convertSpeed
    {
        public static double ConvertMilesPerKilometer(double km)
        {
            return km * 1.60934;
        }

        public static double ConvertMilesPerFoot(double foot)
        {
            return foot * 1.46667;
        }

        public static double ConvertMilesPerMetre(double metre)
        {
            return metre * 0.44704;
        }
    }

    public static class convertArea
    {
        public static double squaremile(double squaremile)
        {
            return squaremile * 3.8610000000;
        }

        public static double squareyard(double yard)
        {
            return yard * 1.19599;
        }

        public static double squarefoot(double foot)
        {
            return foot * 10.7639;
        }

        public static double acrea(double acrea)
        {
            return acrea * 0.000247105;
        }
    }
}
