﻿using System;

namespace Ex010
{
    class Program
    {
        static void Main(string[] args)
        {
            Dados[] vect = new Dados[10];

            Console.WriteLine("How many rooms will be rented? ");
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rent # {i}: ");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = (Console.ReadLine());
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());

                vect[room] = new Dados(name, email);
            }

            {
                Console.WriteLine();
                Console.WriteLine("Busy rooms: ");
                for (int i = 0; i < 10; i++)
                {
                    if (vect[i] != null)
                    {
                        Console.WriteLine(i + ": " + vect[i]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}