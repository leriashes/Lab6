using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class Publishing
	{
		private String name;    //Название
		private String city;    //Город

		static Exception ex;

		//Конструктор
		public Publishing()
		{
			name = "Издательство №1";
			city = "г. Москва";
		}

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
				try
				{
					name = Console.ReadLine();

					for (int i = 0; i < name.Length; i++)
					{
						if (name.Substring(i, 1) == " ")
						{
							if (i == 0 || i < name.Length - 1 && name.Substring(i + 1, 1) == " " || i == name.Length - 1)
							{
								name = name.Substring(0, i) + name.Substring(i + 1, name.Length - i - 1);
								i--;
							}
						}
					}

					if (name.Length == 0)
					{
						throw ex = new Exception("\nОшибка ввода! Повторите ввод: ");
					}
					else
					{
						f = false;
					}
				}
				catch (Exception ex)
				{
					Console.Write(ex.Message);
				}
			} while (f);

			f = true;
			Console.Write("\nВведите населённый пункт, в котором находится издательство (например: г. Барнаул): ");
			do
			{
				try
				{
					city = Console.ReadLine();

					for (int i = 0; i < city.Length; i++)
					{
						if (city.Substring(i, 1) == " ")
						{
							if (i == 0 || i < city.Length - 1 && city.Substring(i + 1, 1) == " " || i == city.Length - 1)
							{
								city = city.Substring(0, i) + city.Substring(i + 1, city.Length - i - 1);
								i--;
							}
						}
					}

					if (city.Length == 0)
					{
						throw ex = new Exception("\nОшибка ввода! Повторите ввод: ");
					}
					else
					{
						f = false;
					}
				}
				catch (Exception ex)
				{
					Console.Write(ex.Message);
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
