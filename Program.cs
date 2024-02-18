using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Title = "Практикум 2 - Сакары Анны";

            ////1. Составить программные коды к задачам, которые реализуют диалог с пользователем, в одном проекте.

            ////1) запрашивает с клавиатуры два целых числа, и выводит на экран сумму данных чисел:

            Console.Write("num = ");
            int num = int.Parse(Console.ReadLine());
            Console.Write("num1 = ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num}+{num1} = {num + num1}");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...");
            Console.ReadKey();
            //2)  запрашивает с клавиатуры два целых числа, и выводит на экран сумму данных чисел в прямом и обратном порядке:

            Console.Write("num2 = ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("num3 = ");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num2}+{num3} = {num3}+{num2}");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...");
            Console.ReadKey();
            //3) запрашивает с клавиатуры два вещественных числа, и выводит на экран произведение данных чисел
            //(вещественные числа выводятся с точностью до 1 знака после запятой):

            Console.Write("num4 = ");
            float num4 = float.Parse(Console.ReadLine());
            Console.Write("num5 = ");
            float num5 = float.Parse(Console.ReadLine());
            Console.WriteLine($"{num4:f2}*{num5:f2} = {num4 * num5:f2}");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...");
            Console.ReadKey();
            //4) запрашивает с клавиатуры три вещественных числа, и выводит на экран следующее сообщение
            //(вещественные числа выводятся с точностью до 2 знаков после запятой):

            Console.Write("num6 = ");
            float num6 = float.Parse(Console.ReadLine());
            Console.Write("num7 = ");
            float num7 = float.Parse(Console.ReadLine());
            Console.Write("num8 = ");
            float num8 = float.Parse(Console.ReadLine());
            Console.WriteLine($"({num6:f2}+{num7:f2})+{num8:f2} = {num6:f2} + ({num7:f2}+{num8:f2}");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...");
            Console.ReadKey();
            //5) запрашивает с клавиатуры четыре вещественных числа,
            //и выводит на экран результат деления первого числа на второе плюс третьего на четвертое
            //(вещественные числа выводятся с точностью до 2 знаков после запятой):

            Console.Write("num9 = ");
            float num9 = float.Parse(Console.ReadLine());
            Console.Write("num10 = ");
            float num10 = float.Parse(Console.ReadLine());
            Console.Write("num11 = ");
            float num11 = float.Parse(Console.ReadLine());
            Console.Write("num12 = ");
            float num12 = float.Parse(Console.ReadLine());
            Console.WriteLine($"({num9:f2}/{num10:f2})+{num11:f2}/{num12:f2} = {num9 / num10 + num11 / num12:f2}");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...");
            Console.ReadKey();
            //6) запрашивает с клавиатуры два целых числа, и выводит на экран результат их суммы, разности и произведения:

            Console.Write("num13 = ");
            int num13 = int.Parse(Console.ReadLine());
            Console.Write("num14 = ");
            int num14 = int.Parse(Console.ReadLine());
            Console.WriteLine($"num13+num14={num13}+{num14} = {num13 + num14}\tnum13-num14={num13}-{num14}={num13 - num14}\tnum13*num14={num13}*{num14}={num13 * num14}");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...");
            Console.ReadKey();
            //7) запрашивает с клавиатуры четыре целых числа,
            //и выводит на экран результат умножения первого числа на третье минус произведение второго числа на четвертое:

            Console.Write("num15 = ");
            int num15 = int.Parse(Console.ReadLine());
            Console.Write("num16 = ");
            int num16 = int.Parse(Console.ReadLine());
            Console.Write("num17 = ");
            int num17 = int.Parse(Console.ReadLine());
            Console.Write("num18 = ");
            int num18 = int.Parse(Console.ReadLine());
            Console.WriteLine($"num15*num17-num16*num18 = {num15}*{num17}-{num16}*{num18} = {num15 * num17 - num16 * num18}");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...");
            Console.ReadKey();
            //8) запрашивает с клавиатуры три целых числа и выводит следующее сообщение [a*(b+c)]=[(b+c)*a]:

            Console.Write("num19 = ");
            int num19 = int.Parse(Console.ReadLine());
            Console.Write("num20 = ");
            int num20 = int.Parse(Console.ReadLine());
            Console.Write("num21 = ");
            int num21 = int.Parse(Console.ReadLine());
            Console.WriteLine($"[num19*(num20+num21)]=[(num21+num20)*num19]:\t{num19 * (num20 + num21)}");
            Console.ReadKey();

            Console.Title = "Самостоятельная работа - Сакары Анны";
            //1. Запрашивает с клавиатуры три целых числа, и выводит на экран произведение данных чисел в прямом и обратном порядке:

            Console.Write("num2 = ");
            int num22 = int.Parse(Console.ReadLine());
            Console.Write("num3 = ");
            int num23 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num22}*{num23} = {num23}*{num22}");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...");
            Console.ReadKey();
            //2. Переменной целого типа х присвоить значение, равное половине произведения значений а, b, с:

            Console.Write("num24 = ");
            int num24 = int.Parse(Console.ReadLine());
            Console.Write("num25 = ");
            int num25 = int.Parse(Console.ReadLine());
            Console.Write("num26 = ");
            int num26 = int.Parse(Console.ReadLine());
            int num27;
            Console.WriteLine($"num27 = ({num24}*{num25}*{num26})/2 = ({num24}*{num25}*{num26})/2 = {(num24 * num25 * num26) / 2}");
            Console.WriteLine("Нажмите на любую клавишу для продолжения...");
            Console.ReadKey();

            //3. Запрашивает с клавиатуры три целых числа, и выводит на экран результат деления первого числа на PI (с точностью 4 знака после запятой),
            //сумму данных чисел и результат деления третьего числа на Е (с точностью 3 знака после запятой):

            Console.Write("num28 = ");
            double num28 = double.Parse(Console.ReadLine());
            Console.Write("num29 = ");
            double num29 = double.Parse(Console.ReadLine());
            Console.Write("num30 = ");
            double num30 = double.Parse(Console.ReadLine());
            Console.WriteLine($"num28/PI = {num28}/{Math.PI:f4} = {num28 / Math.PI:f4}\tnum28+num29+num30 = {num28}+{num29}+{num30} = {num28+num29+num30}\t num30/E = {num30}/{Math.E:f3} = {num30 / Math.E:f3}");
            Console.ReadKey();


        }
    }
}
