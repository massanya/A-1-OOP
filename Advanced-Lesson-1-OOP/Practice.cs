using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public class Practice
    {
		/// <summary>
		/// A.L1.P1. Вывести матрицу (двумерный массив) отображающую площадь круга, 
		/// квадрата, равнобедренного треугольника со сторонами (радиусами) от 1 до 10.
		/// </summary>
		static Random rnd = new Random();

		public static void A_L1_P1_OOP()
		{
			int[,] arr = new int[10, 3];
			for (int i = 1; i < 10; i++)
			{
				arr[i, 0] = (new Rectangle(rnd.Next(1, 10), rnd.Next(1, 10))).Draw();
			}
			for (int i = 1; i < 10; i++)
			{
				arr[i, 1] = (new Circle(rnd.Next(1, 10))).Draw();
			}
			for (int i = 1; i < 10; i++)
			{
				arr[i, 2] = (new Triangle(rnd.Next(5, 10), rnd.Next(5, 10), rnd.Next(1, 5))).Draw();
			}
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 10; j++)
				{
					Console.Write(arr[j, i] + "|");
				}
				Console.WriteLine();
			}
		}

		/// <summary>
		/// A.L1.P6. Перегрузить следующие операторы для Transport <>,==/!= на базе физических размеров. 
		/// Продемонстрировать использование в коде. 
		/// </summary>
		public static void A_L1_P6_OperatorsOverloading()
        {
        }

        /// <summary>
        /// A.L1.P7.Перегрузить операторы<>,==/!=  для продаваемых вещей в интернет магазине на базе их цены. 
        /// Продемонстрировать использование в коде. 
        /// </summary>
        public static void A_L1_P7_OperatorsOverloading()
        {            
        }        
    }
}
