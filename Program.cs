using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
                       
                          int i = 10 ;
                        int j ;
                          int 10;
                        //Array - declare array

                        // declare array first way 

                        int[] fees = new int[5];
                        fees[0] = 12000;
                        fees[1] = 13000;
                        fees[2] = 14000;
                        fees[3] = 15000;
                        fees[4] = 16000;

                        Console.WriteLine($"number of atems ={fees.Length}");

                        // declare array second way

                        string[] names = new string[5]
                        {"sagar","karan","gopal","radhesh","gotya"};
                        Console.WriteLine($" \n number of names :  {names.Length}");

                        for (int i = 0; i < names.Length; i++)
                        {
                            Console.WriteLine($" {names[i]} "); 
                        }

                        string email = null;
                      Console.WriteLine($"number of email : {email.Length}"); // runtime error 
           
                        // reverce array 

                                    int[] numbers = new int[] { 9,8,7,6,5,4,3,2,1 };
                                    Console.WriteLine("original items");
                                    for (int i = 0; i < numbers.Length; i++)
                                    { 
                                        Console.Write($"{numbers[i]} ");
                                    }
                                    Console.WriteLine($"\n Reverce Array");
                                    for (int i = numbers.Length - 1; 1 >= 0; i--)
                                    {
                                        Console.Write($"{numbers[i]}");  


                        int[] numbers = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

                        int highest = 0;
                        for (int i = 0;i < numbers.Length; i++) 
                        { 
                            for (int j = i  + 1 ; j < numbers.Length; j++)
                            {
                                if (numbers[j] > highest) 
                                {
                                    highest = numbers[j];
                                }
                            }
                        }
                        Console.WriteLine($"\n highest number : {highest}");

                        // reverce Array    o/p 1,2,3,4,5,6,7,8,9,

                        Console.WriteLine("origin items");
                        for (int i = 0; i < names.Length ; i++)
                        {
                            Console.Write($"{numbers[i]}");
                        }
                        Console.WriteLine("\nreverce array");
                        for ( int i =  numbers.Length - 1; i >= 0 ; i--)
                        {
                            Console.Write($"{numbers[i]}");
                        }
           

            //find higher number 
            // int[] numbers = new int[] { 10, 23, 45, 34, 67, 76, 234, 576 };

            int[] numbers = new int[] { 10, 23, 45, 34, 67, 76, 234, 576 };

              int highest = 0;
              for (int i = 0; i < numbers.Length; i++)
              {
                  //highest = numners [i];
                  for (int j = i; j  < numbers.Length; j++)
                  {
                      if (numbers[j] > highest)
                      {
                          highest = numbers[j];
                      }
                  }
              }
                  Console.WriteLine($"\n highest number : {highest}");
 

            // reversce inpir string 

           Console.WriteLine("please enter your name");
             string name = Console.ReadLine();

             string reverceName = string.Empty;
             for (int i = name.Length - 1 ; i >= 0; i--)
             {
                 reverceName += name[i];
             }
             Console.WriteLine($" inpur : {name} output : {reverceName}" );



 

            // reverce number in sentence 

            Console.WriteLine("please enter your sentence ");
            string sentence = Console.ReadLine();

            string[] world = sentence.Split(new char[] { ' ' });

            Console.WriteLine("output  : \n ");

            for (int i = world.Length - 1; i >= 0; i--)
            {
                Console.Write($"{world[i]}");
            }

            Console.ReadLine();
        }
    }
}
