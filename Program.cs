using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class Program
	{
		static void Main(string[] args)
		{
			//Работа с объектами класса Date
			Console.WriteLine("Работа с объектами класса Date");

			Date date_1 = new Date();   //Создание через конструктор без параметров

			//Создание через конструкторы с параметрами
			Date date_2 = new Date(12, 02, 2004);
			Date date_3 = new Date(26, 35, 12, 13, 05, 1997);

			//Печать созданных объектов
			Console.Write("\nПечать данных объектов\ndate_1 = ");
			date_1.Display("all");
			Console.Write("\ndate_2 = ");
			date_2.Display("all");
			Console.Write("\ndate_3 = ");
			date_3.Display("all");
			Console.WriteLine();

			//Ввод только времени
			Console.WriteLine("\n\nВвод только времени");

			date_1.ReadTime();
			Console.Write("\ndate_1 = ");
			date_1.Display("all");
			Console.WriteLine();

			///Ввод только даты
			Console.WriteLine("\n\nВвод только даты");

			date_1.ReadDate();
			Console.Write("\ndate_1 = ");
			date_1.Display("all");
			Console.WriteLine();

			//Вывод значений полей в выбранном формате
			Console.Write("\n\nВывод значений полей в выбранном формате (помимо полного вывода)\ndate_1 (hh:mm:ss) = ");
			date_1.Display("hh:mm:ss");
			Console.Write("\ndate_1 (hh:mm) = ");
			date_1.Display("hh:mm");
			Console.Write("\ndate_1 (mm:ss) = ");
			date_1.Display("mm:ss");
			Console.Write("\ndate_1 (DD.MM.YYYY) = ");
			date_1.Display("DD.MM.YYYY");
			Console.Write("\ndate_1 (DD/MM/YYYY) = ");
			date_1.Display("DD/MM/YYYY");
			Console.Write("\ndate_1 (MM.DD.YYYY) = ");
			date_1.Display("MM.DD.YYYY");
			Console.Write("\ndate_1 (DD-MM-YYYY) = ");
			date_1.Display("DD-MM-YYYY");
			Console.Write("\ndate_1 (YYYY-MM-DD) = ");
			date_1.Display("YYYY-MM-DD");
			Console.WriteLine();

			//Получение текущей даты и времени
			Console.Write("\n\nТекущая дата и время\ndate_2 = ");
			date_2.Now();
			date_2.Display("all");

			//Сравнение дат
			Console.WriteLine("\n\n\nСравнение дат (сколько времени от первой даты до второй)\n");
			date_2.Display("all");
			Console.Write(" и ");
			date_3.Display("all");
			Console.WriteLine();
			(date_2.Compare(date_3)).Display("CompareResult");
			Console.WriteLine();
			(date_2.Compare(date_3)).Display("CompareResultRU");
			Console.WriteLine();

			//Инициализация значений
			Console.Write("\n\nИнициализация значений");
			date_1.Init(30, 5, 11, 27, 6, 2010);
			Console.Write("\ndate_1 = ");
			date_1.Display("all");

			date_3.Init(30, 5, 7, 2, 2, 1);
			Console.Write("\ndate_3 = ");
			date_3.Display("all");
			Console.WriteLine();

			//Прибавление времени к дате
			Console.Write("\n\nПрибавление времени date_3 к дате date_1: ");
			(date_1.Add(date_3)).Display("all");
			Console.WriteLine();

			//Проверка является дата годовщиной другой
			Console.WriteLine("\n\nПроверка является ли вторая дата 'годовщиной' первой\n");
			date_1.Display("all");
			Console.Write(" и ");
			date_2.Display("all");
			if (date_1.IsAnniversary(date_2))
			{
				Console.WriteLine(": да.");
			}
			else
			{
				Console.WriteLine(": нет.");
			}

			date_1.Display("all");
			Console.Write(" и ");
			date_3.Display("all");
			if (date_1.IsAnniversary(date_3))
			{
				Console.WriteLine(": да.");
			}
			else
			{
				Console.WriteLine(": нет.");
			}

			Console.Write("\nНажмите любую клавишу...");
			Console.ReadKey();
		}
	}
}
