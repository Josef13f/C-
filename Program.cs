﻿ //Задайте значения M и N. Напишите программу, которая выведет 
 //все натуральные числа в промежутке от M до N. 
 //Использовать рекурсию, не использовать циклы.

void ShowNumbers(int start, int end)
{
    if(start == end)
{
    Console.Write (start);
    return;
}

Console.Write (start + " ");
ShowNumbers(start+1, end);
} 
int M = 1;
int N = 8;
ShowNumbers(M, N);
