using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class Address
	{
		private String city;    //Название населённого пункта
		private String street;  //Название улицы
		private int house;      //Номер дома
		private int flat;       //Номер квартиры

		static Exception ex;

		//Конструктор
		public Address()
		{
			city = "г. Москва";
			street = "Ленинский проспект";
			house = 1;
			flat = 1;
		}

		//Конструктор с параметром
		public Address(String city, String street, int house_number, int flat_number)
		{
			this.city = city;
			this.street = street;
			house = house_number;
			flat = flat_number;
		}

		//Инициализация всех полей
		public void Init(String city, String street, int house_number, int flat_number)
		{
			this.city = city;
			this.street = street;
			house = house_number;
			flat = flat_number;
		}

		//Ввод значений всех полей
		public void Read()
		{
			bool f = true;

			String str;
			
			Console.Write("Введите название населённого пункта (например: г. Барнаул): ");
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

			f = true;
			Console.Write("\nВведите название улицы (например: ул. Попова): ");
			do
			{
				try
				{
					street = Console.ReadLine();

					for (int i = 0; i < street.Length; i++)
					{
						if (street.Substring(i, 1) == " ")
						{
							if (i == 0 || i < street.Length - 1 && street.Substring(i + 1, 1) == " " || i == street.Length - 1)
							{
								street = street.Substring(0, i) + street.Substring(i + 1, street.Length - i - 1);
								i--;
							}
						}
					}

					if (street.Length == 0)
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
			Console.Write("\nВведите номер дома: ");
			do
			{
				str = Console.ReadLine();

				try
				{
					house = int.Parse(str);
				}
				catch (FormatException)
				{
					house = 0;
				}

				if (house <= 0)
				{
					Console.Write("\nОшибка ввода! Повторите ввод: ");
				}
				else
				{
					f = false;
				}
			} while (f);

			f = true;
			Console.Write("\nВведите номер квартиры: ");
			do
			{
				str = Console.ReadLine();

				try
				{
					flat = int.Parse(str);
				}
				catch (FormatException)
				{
					flat = 0;
				}

				if (flat <= 0)
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
			Console.Write($"{city}, {street} {house}, {flat}");
		}

		//Проверка совпадения города
		public bool City(String city)
		{
			bool result = false;

			if (String.Compare(this.city,city) == 0)
			{
				result = true;
			}

			return result;
		}
	}
}
