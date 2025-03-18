using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace collectionTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() ; 
            string option;

            do {
               

                Console.WriteLine(" P - Print numbers");
                Console.WriteLine(" A - Add a number");
                Console.WriteLine(" M - Display mean of the numbers");
                Console.WriteLine(" S - Display the smallest number");
                Console.WriteLine(" L - Display the largest number");
                Console.WriteLine(" F - Find a number");
                Console.WriteLine(" C - Clear list");
                Console.WriteLine(" Q - Quit");
                Console.WriteLine("-------------------------------------");
                Console.Write(" Enter your choice:");

                option = Console.ReadLine().ToUpper();

                switch (option) {
                    case "P": 
                        if (numbers.Count() == 0)
                            Console.WriteLine("[] - the list is empty");
                        else
                        {
                            Console.Write("[ ");
                            for(int i = 0;i < numbers.Count(); i++)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                            Console.WriteLine("]");
                           
                        }
                        Console.WriteLine("==========================");
                        break;

                    case "A":
                        Console.Write("Enter The Number:");
                        int addedNum = int.Parse(Console.ReadLine());
                        bool exist = false;
                        if (numbers.Count() > 0)
                        {//Don't allow duplicate entries
                            for (int i = 0; i < numbers.Count(); i++)
                            {
                                if (addedNum == numbers[i])
                                {
                                    Console.WriteLine("Number is already exist");
                                    Console.WriteLine("==========================");
                                    exist = true;
                                    break;
                                }
                            }
                        }
                        if (!exist)//add the number if is not exist before
                        {
                            numbers.Add(addedNum);
                            Console.WriteLine($"{numbers[^1]} added");
                            Console.WriteLine("==========================");
                        }
                        break;

                    case "M":
                        if (numbers.Count() == 0)
                            Console.WriteLine("Unable to calculate the mean - no data");
                        else
                        {
                            double sum = 0;
                            double mean = 0;
                            for (int i = 0; i < numbers.Count(); i++)
                            {
                                sum += numbers[i];
                            }

                            mean = sum / numbers.Count();

                            Console.WriteLine($"The Mean Is:{mean}");
                            Console.WriteLine("==========================");

                        }
                        break;
                    case "S":
                        if (numbers.Count() > 0) {
                            int smallestNum = numbers[0];
                            for (int i = 0; i < numbers.Count(); i++)
                            {
                                if (numbers[i] < smallestNum)
                                    smallestNum = numbers[i];

                            }
                            Console.WriteLine("The smallest number is " + smallestNum);

                        }else
                            Console.WriteLine("Unable to determine the smallest number - list is empty");

                        Console.WriteLine("==========================");
                        break;
                    case "L":
                        if (numbers.Count() > 0)
                        {
                            int largestNum = numbers[0];
                            for (int i = 0; i < numbers.Count(); i++)
                            {
                                if (numbers[i] > largestNum)
                                    largestNum = numbers[i];

                            }
                            Console.WriteLine("The largest Number is " + largestNum);

                        }
                        else
                            Console.WriteLine("Unable to determine the  largest Number - list is empty");

                        Console.WriteLine("==========================");
                        break;
                    case "F":
                        Console.Write("Enter the number to search :");
                        int numTosearch = int.Parse(Console.ReadLine());
                        bool found = false;
                        for(int i = 0; i < numbers.Count(); i++)
                        {
                            if (numTosearch == numbers[i])
                            {
                                Console.WriteLine("Nedded numbere in index " + i);
                                found = true;
                                break;
                            }
                       
                        }
                        if (!found)
                            Console.WriteLine("nedded number not in the list[]");
                        Console.WriteLine("==========================");
                        break;
                    case "C":
                        numbers.Clear();
                        Console.WriteLine("List clear succesfully");
                        break;
                    case "Q":   
                        break;
                    default:
                        Console.WriteLine("Invalid option !!");
                        break;
                }

            } while (option != "Q");


        }
    }
}
