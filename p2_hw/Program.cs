﻿//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

// int number = new Random().Next(100, 1000); // 100-999

// int digit = number % 100; //  десятки

// int thirdDigit = number % 10; // единицы

// int result = (digit - thirdDigit) / 10;

// Console.WriteLine("Исходное число: " + number);
// Console.WriteLine("Вторая цифра числа: " + result);

//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

// Console.Write("Укажите целое число:");
// int dig = Convert.ToInt32(Console.ReadLine());

// if (100 < dig && dig <1000) //фильтр трехзначного числа
// {
//     Console.WriteLine("Третья цифра числа: " + dig%10);
// }
// else if (10 < dig && dig <100) //фильтр двухзначного числа
// {
//     Console.WriteLine("Число двухзначное: " + dig);
// }
// else
// {
//     Console.WriteLine("Это нам не задавали: " + dig);  // число вне диапазона задачи
// }


//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели,и проверяет, является ли этот день выходным.

// Console.Write("Укажите номер дня недели:");
// int  day = Convert.ToInt32(Console.ReadLine());

// if (day == 6 || day == 7)
//{
// Console.Write ("выходной день" );
//}
// else
// Console.Write("рабочий день");

    