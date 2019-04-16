using System;

namespace htc_final_project_Cehelnik
{
    class Program
    {
        static void Main(string[] args)
        {
            bool KeepGoing = true;

            while (KeepGoing == true) {
            Console.WriteLine("What do you need to calculate? Area of a Triangle, Perimeter of a Triangle, Area of a Square, Perimeter of a Square, Area of a Circle, or Perimeter of a Circle");
           //make list for types of calculator
            string choice = Console.ReadLine();
                        if (choice == "Area of a Triangle"){
                            int val = aTriangle();
                            Console.WriteLine(val);
                        }


            Console.WriteLine("Do you want continue? Y or N");
            string YN = Console.ReadLine();
            if (YN == "Yes"){
                KeepGoing = true;
            }
            else {
                KeepGoing = false;
            }
            }
        }
        //Copy aTriangle and change to type 
        public static int aTriangle (){
                Console.WriteLine("Enter A values: ");
                string xValue = Console.ReadLine();
                int XValue = Convert.ToInt32(xValue);
                Console.WriteLine("Enter B value: ");
                string yValue = Console.ReadLine();
                int YValue = Convert.ToInt32(yValue);
                int XYValues = XValue * YValue;
                int finaltriangle = XYValues / 2;
                return finaltriangle;
            
        }
        //pTriangle chage to A B C make it plus
        public static int pTriangle (){
                Console.WriteLine("Enter A values: ");
                string xValue = Console.ReadLine();
                int XValue = Convert.ToInt32(xValue);
                Console.WriteLine("Enter Y value: ");
                string yValue = Console.ReadLine();
                int YValue = Convert.ToInt32(yValue);
                int XYValues = XValue * YValue;
                int finaltriangle = XYValues / 2;
                return finalptriangle;
            
        }
        }
    }

