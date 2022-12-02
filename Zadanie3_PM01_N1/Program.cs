using System;

namespace Variant10
{
	class Program
	{
		static double fx(double number)
		{
			return (number % 5 == 0) ? number / 5 : number + 1;
		}

		static void Main()
		{
			try
			{
				Console.Write("Введите любое число^ ");
				double number = double.Parse(Console.ReadLine());
				double res = fx(number);
				Console.WriteLine(res);
			}
			catch
			{
				Console.WriteLine("Введены некорректные данные.");
			}
			
		}
	}
}