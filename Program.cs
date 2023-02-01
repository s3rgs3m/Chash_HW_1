// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите номер задачи 2, 4, 6 или 8");
if (int.TryParse(Console.ReadLine(), out int TaskNumber)){
    switch(TaskNumber){
        case 2: // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            Console.WriteLine ("Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
            Console.WriteLine ("Введите первое число");
            if (double.TryParse(Console.ReadLine(), out double num1)) {
                Console.WriteLine ("Введите второе число");
                if (double.TryParse(Console.ReadLine(), out double num2)) {
                    switch (num1-num2){
                        case <0:
                            Console.WriteLine ("Второе число '"+ num2 + "' больше чем первое число '" + num1 + "'");
                            break;
                        case >0:
                            Console.WriteLine ("Первое число '"+ num1 + "' больше чем второе число '" + num2 + "'");
                            break;
                        default:
                            Console.WriteLine ("Числа '"+ num1 + "' и '" + num2 + "' равны");
                            break;
                    }
                }
                else Console.WriteLine ("Число введено неверно");
            }
            else Console.WriteLine ("Число введено неверно");
            break;
        case 4: // Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            Console.WriteLine ("Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
            Console.WriteLine ("Введите первое число");
            if (double.TryParse(Console.ReadLine(), out double t4num1)) {
                Console.WriteLine ("Введите второе число");
                if (double.TryParse(Console.ReadLine(), out double t4num2)) {
                    Console.WriteLine ("Введите третье число");
                    if (double.TryParse(Console.ReadLine(), out double t4num3)) {
                        double max12 = t4num1 > t4num2 ? t4num1 : t4num2 ;
                        double finalMax = t4num3 > max12 ? t4num3 : max12 ;
                        Console.WriteLine ("Максимальное число из этих 3х: '" + finalMax + "'");    
                    }
                    else Console.WriteLine ("Число введено неверно");    
                }
                else Console.WriteLine ("Число введено неверно");
            }
            else Console.WriteLine ("Введено не целое число");
            break;
        case 6: // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            Console.WriteLine ("Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)");
            Console.WriteLine ("Введите целое число");
            if (int.TryParse(Console.ReadLine(), out int num6)) {
                if (num6 % 2 == 0 ) 
                    Console.WriteLine ("Число четное");
                else 
                    Console.WriteLine ("Число нечетное");
            }
            else Console.WriteLine ("Целое число введено неверно");
            break;
        case 8: // Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
            Console.WriteLine ("Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");
            Console.WriteLine ("Введите число");
            if (double.TryParse(Console.ReadLine(), out double N)) {
                Console.Write ("Четные числа от 1 до " + N +" :");
                for (int i=1; i<=N; i++){
                    Console.Write(i%2==0 ? " " + i : "");
                }
            }
            else Console.WriteLine ("Число введено неверно");
            break;
        default:
            Console.WriteLine("Такого номера задачи нет");
            break;
    }
}
else Console.WriteLine ("Введен не номер задачи");
