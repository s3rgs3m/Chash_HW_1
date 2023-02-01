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

Console.WriteLine("Введите номер задачи 2, 4 или 8");
if (int.TryParse(Console.ReadLine(), out int TaskNumber)){
    switch(TaskNumber){
        case 2: // Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            Console.WriteLine ("Введите первое целое число");
            if (int.TryParse(Console.ReadLine(), out int num1)) {
                Console.WriteLine ("Введите второе целое число");
                if (int.TryParse(Console.ReadLine(), out int num2)) {
                    switch (num1-num2){
                        case <0:
                            Console.WriteLine ("Второе число "+ num2 + " больше чем первое число " + num1 );
                            break;
                        case >0:
                            Console.WriteLine ("Первое число "+ num1 + " больше чем второе число " + num2 );
                            break;
                        default:
                            Console.WriteLine ("Числа "+ num1 + " и " + num2 + " равны");
                            break;
                    }
                }
                else Console.WriteLine ("Введено не целое число");
            }
            else Console.WriteLine ("Введено не целое число");

            break;
        case 4:
            Console.WriteLine ("4");
            break;
        case 8:
            Console.WriteLine ("8");
            break;
        default:
            Console.WriteLine("Такого номера задачи нет");
            break;
    }
}
else Console.WriteLine ("Введен не номер задачи");
