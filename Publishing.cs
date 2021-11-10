using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	struct Publishing
	{
		private String name;    //Название
		private String city;    //Город

		//Конструктор с параметром
		public Publishing(String name, String city)
		{
			this.name = name;
			this.city = city;
		}

		//Инициализация всех полей
		public void Init(String name, String city)
		{
			this.name = name;
			this.city = city;
		}

		//Ввод всех полей
		public void Read()
		{
			bool f = true;

			Console.Write("Введите название издательства: ");
			do
			{
				name = Console.ReadLine();

				if (name.Length == 0)
				{
					Console.Write("\nОшибка ввода! Повторите ввод: ");
				}
				else
				{
					f = false;
				}
			} while (f);

			f = true;
			Console.Write("\nВведите населённый пункт, в котором находится издательство (например: г. Барнаул): ");
			do
			{
				city = Console.ReadLine();

				if (city.Length == 0)
				{
					Console.Write("\nОшибка ввода! Повторите ввод: ");
				}
				else
				{
					f = false;
				}
			} while (f);
		}

		//Вывод значений всех полей
		public void Display()
		{
			Console.Write($"{name} ({city})");
		}

		//Проверка находится ли издательство в заданном городе
		public bool IsHere(String city)
		{
			bool result = false;

			if (String.Compare(this.city, city) == 0)
			{
				result = true;
			}

			return result;
		}
	}
}
