/*Используя Visual Studio, создайте проект по шаблону Console Application.  
Создайте четыре лямбда оператора для выполнения арифметических действий: (Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). 
Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.Лямбда оператор деления должен делать проверку деления на ноль.
Написать программу, которая будет выполнять арифметические действия указанные пользователем.
*/
using System;

namespace Task2
{
    class Program
    {
        delegate double CalculatorDelegate (int a, int b);

        static void Main(string[] args)
        {
            int firstValue = 7, secondValue = 4;
            CalculatorDelegate AddDelegate = (int firstDigit, int secondDigit) => { return firstDigit + secondDigit; };
            CalculatorDelegate SubDelegate = (int firstDigit, int secondDigit) => { return firstDigit - secondDigit; };
            CalculatorDelegate Mul = (int firstDigit, int secondDigit) => { return firstDigit * secondDigit; };
            CalculatorDelegate Del = (int firstDigit, int secondDigit) => { return firstDigit / secondDigit; };
        }
    }
}
