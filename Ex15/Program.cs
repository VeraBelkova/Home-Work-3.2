﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int n = Convert.ToInt32(Console.ReadLine());
if (n <= 5){
   Console.WriteLine("работаем");
}
if (n > 5 && n <= 7){
   Console.WriteLine("отдыхаем");
  }
if (n > 7){
  Console.WriteLine("это не день недели");
}
    


