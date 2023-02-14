int programm;
Boolean begin = true;

while (begin)
{
    Console.WriteLine("-----------------------------------------------------------------------------");
    Console.WriteLine("Введите число для соответствующей задачи или иное для выхода: ");
    Console.WriteLine("1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
    Console.WriteLine("2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
    Console.WriteLine("3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
    programm = Convert.ToInt32(Console.ReadLine());
    
    switch (programm)
    {
        case 1:
           /* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
                3, 5 -> 243 (3⁵)
                2, 4 -> 16     */
            Console.WriteLine("введите число A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите число B");
            int b = Convert.ToInt32(Console.ReadLine());
            int s = a;

            for (int i = 1; i < b; i++)
            {
                s = s * a;
            }
            Console.WriteLine("A в степени B равно: " + s);

            break;
        case 2:
           /* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
                452 -> 11
                82 -> 10
                9012 -> 1       */
            
            Console.Write("Введите целое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (n > 0)
            {
                int num = n % 10;
                n = n / 10;
                sum = sum + num;
            }
            Console.WriteLine("Сумма равна: " + sum);

            break;
        case 3:
            /* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
                1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
                6, 1, 33 -> [6, 1, 33]   */
            
            int [] numbers = new int[8];
            Console.Write("[");

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers [i] = new Random().Next(0, 11);
                Console.Write(" " + Method (i) + " ");
            }
            Console.Write("]");

            int Method (int a)
            {
                return numbers[a];
            }
            
            break;
    }
}