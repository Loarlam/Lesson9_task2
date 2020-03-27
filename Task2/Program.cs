/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). 
Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления. Лямбда оператор деления должен делать проверку деления на ноль.
Написать программу, которая будет выполнять арифметические действия указанные пользователем.
*/
using System;

namespace Task2
{
    class Program
    {
        delegate double CalculatorDelegate(int a, int b);

        static void Main(string[] args)
        {
            CalculatorDelegate Add, Sub, Mul, Del;
            int firstValue = 7, secondValue = 4;
            double resultAdd, resultSub, resultMul, resultDel;

            Add = (int firstDigit, int secondDigit) => { return firstDigit + secondDigit; };
            Sub = (int firstDigit, int secondDigit) => { return firstDigit - secondDigit; };
            Mul = (int firstDigit, int secondDigit) => { return firstDigit * secondDigit; };
            Del = (int firstDigit, int secondDigit) =>
            {
                if (secondDigit != 0) return firstDigit / secondDigit;
                return 0;
            };

            resultAdd = Add(firstValue, secondValue);
            resultSub = Sub(firstValue, secondValue);
            resultMul = Mul(firstValue, secondValue);
            resultDel = Del(firstValue, secondValue);

            Console.WriteLine($"{firstValue} + {secondValue} = {resultAdd}");
            Console.WriteLine($"{firstValue} - {secondValue} = {resultSub}");
            Console.WriteLine($"{firstValue} * {secondValue} = {resultMul}");
            if (Del(firstValue,secondValue)!=0) Console.WriteLine($"{firstValue} / {secondValue} = {resultDel}");
            else Console.WriteLine("На ноль делить нельзя!");

            Console.ReadKey();
        }
    }
}
