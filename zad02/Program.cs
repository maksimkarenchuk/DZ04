// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16



double stepen()
 {
   Console.WriteLine("Введите число А ");
   int a = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите число B ");
   int b = Convert.ToInt32(Console.ReadLine());
   double stepen = Math.Pow(a, b);
   return stepen;
 }
 try
 {
    Console.WriteLine($"Число А в степени B = " + stepen());
 }
catch
{
    Console.WriteLine("Числа вводятся цифрами!");
}