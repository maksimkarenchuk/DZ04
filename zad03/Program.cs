// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

string summa()
{
Console.WriteLine("Введите любое положительное число ");
int a = Convert.ToInt32(Console.ReadLine());
string str = a.ToString();
int[] b = new int[str.Length];
        for (int i=0; i< str.Length; i++)
            {
            b[i] = int.Parse(str[i].ToString());
            // Console.Write($"{b[i]},  ");                //выводит массив
            }
           int sum = b.Sum();
           return ($"Сумма чисел в числе {a} = {sum}");
}
    try 
    {
        Console.WriteLine(summa());
    }
    catch
    {
        Console.WriteLine("Пожалуйта цифрами");
    }