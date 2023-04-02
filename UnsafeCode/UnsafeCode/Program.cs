using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnsafeCode
{
    class Program
    {
        //Метод является небезопасным
        //возводит в степень y число x
        unsafe static void Pow(int* x, int y)
        {
            int z = *x;
            for (int i = 1; i < y; i++)
                *x *= z;
        }
        /*Небезопасный блок – это часть кода,
         помеченная флагом unsafe, внутри которого
        можно использовать небезопасный код*/
        unsafe static void Main(string[] args)
        {
            int param = 2;
            //Вызов небезопасного метода
            Pow(&param, 4);
            Console.WriteLine("value is {0}", param);
        }
    }
}
