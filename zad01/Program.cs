﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


void ranmass()
{
    Console.WriteLine("Введите число элементов массива");
        int N=Convert.ToInt32(Console.ReadLine());
        int[] array = new int [N];
        for (int i=0; i<N; i++)
            {
                Console.Write($"{array [i] = new Random().Next(0,100)}, ");  
            }
}
 try 
    {
        ranmass();
    }
    catch
    {
        Console.WriteLine("Пожалуйта цифрами");
    }