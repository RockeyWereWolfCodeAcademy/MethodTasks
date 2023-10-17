using System.Diagnostics;

namespace MethodTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 1 combine two arrays using params
            int[] array1 = { 1, 2, 3 };
            int[] combinedArray = CombineArrays(array1, 4, 3, 5);
            Console.WriteLine("Combined array: ");
            for (int i = 0; i < combinedArray.Length; i++)
            {
                Console.WriteLine(combinedArray[i]);
            }

            //task 2 find minimum element of array
            int minElement = ArrayMin(5, 2, 8, 1, 10);
            Console.WriteLine("Minimum Element: " + minElement);

            //task 3 find min element multiplied by max element of array
            int minMaxProduct = ArrayMaxAndMinMultiplied(5, 2, 8, 1, 10);
            Console.WriteLine("Min Element Multiplied by Max Element: " + minMaxProduct);

            //task 4 find number in power of
            int powerResult = Power(2, 3);
            Console.WriteLine("2^3: " + powerResult);

            //lms task 1 calculate areas
            int circleArea = CalculateArea(5);
            Console.WriteLine("Circle Area: " + circleArea);

            int rectangleArea = CalculateArea(3, 4);
            Console.WriteLine("Rectangle Area: " + rectangleArea);

            int parallelepipedArea = CalculateArea(2, 3, 4);
            Console.WriteLine("Parallelepiped Area: " + parallelepipedArea);

            int triangleInscribedCircleArea = CalculateArea(6, 8, 10, 4);
            Console.WriteLine("Triangle Inscribed Circle Area: " + triangleInscribedCircleArea);

            //lms task 2 operations with 2 numbers
            int operationResult1 = CalculateOperation(5, 3, '+');
            Console.WriteLine("5 + 3: " + operationResult1);

            int operationResult2 = CalculateOperation(8, 4, '/');
            Console.WriteLine("8 / 4: " + operationResult2);

            //lms task 3 find power or square of number
            int squareResult = CalculatePower(4);
            Console.WriteLine("Square of 4: " + squareResult);

            int powerResult3 = CalculatePower(2, 3);
            Console.WriteLine("2^3: " + powerResult3);

            //lms task 4 display name
            DisplayInfo("Mikayil");
            DisplayInfo("Mikayil", "Adilov");
            DisplayInfo("Mikayil", "Adilov", "Mehdi");

        }
        //task 1 combine two arrays using params
        static int[] CombineArrays(int[] array1, params int[] array2)
        {
            int[] combinedArray = new int[array1.Length + array2.Length];
            for (int i = 0; i < combinedArray.Length; i++)
            {
                if (i < array1.Length)
                {
                    combinedArray[i] = array1[i];
                }
                else
                {
                    combinedArray[i] = array2[i - array1.Length];
                }
            }

            return combinedArray;
        }
        //task 2 find minimum element of array
        static int ArrayMin(params int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }
        //task 3 find min element multiplied by max element of array
        static int ArrayMaxAndMinMultiplied(params int[] array)
        {
            int min = array[0];
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return min * max;
        }
        //task 4 find number in power of
        static int Power(int number, int power)
        {
            int temp = number;
            for (int i = 1; i < power; i++)
            {
                number *= temp;
            }
            return number;
        }
        //lms task 1 find the area of various geometric shapes
        //circle
        static int CalculateArea(int radius)
        {
            int pi = 3;
            return pi * Power(radius, 2);
        }

        //rectangle
        static int CalculateArea(int length, int width)
        {
            return length * width;
        }

        //rectangular parallelepiped
        static int CalculateArea(int sideA, int sideB, int sideC)
        {
            return 2 * (sideA * sideB + sideA * sideC + sideB * sideC);
        }

        // circle inscribed in a triangle
        static int CalculateArea(int sideA, int sideB, int sideC, int radius)
        {
            int perimeter = (sideA + sideB + sideC) / 2;
            return perimeter * radius;
        }
        //lms task 2 operations with 2 numbers
        static int CalculateOperation(int a, int b, char operation)
        {
            int result = 0;

            switch (operation)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    if (b != 0)
                    {
                        result = a / b;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }

            return result;
        }
        //lms task 3 find power or square of number
        static int CalculatePower(int number)
        {
            int temp = number;
            for (int i = 1; i < 2; i++)
            {
                number *= temp;
            }
            return number;
        }
        static int CalculatePower(int number, int power)
        {
            int temp = number;
            for (int i = 1; i < power; i++)
            {
                number *= temp;
            }
            return number;
        }
        //lms task 4 display name 
        static void DisplayInfo(string name)
        {
            Console.WriteLine(name);
        }

        static void DisplayInfo(string name, string surname)
        {
            Console.WriteLine(surname + " " + name);
        }

        static void DisplayInfo(string name, string surname, string fatherName)
        {
            Console.WriteLine(name[0] + ". " + surname + " " + fatherName);
        }
    }
}