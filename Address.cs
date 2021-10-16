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

			f = true;
			Console.Write("\nВведите название улицы (например: ул. Попова): ");
			do
			{
				street = Console.ReadLine();

				if (street.Length == 0)
				{
					Console.Write("\nОшибка ввода! Повторите ввод: ");
				}
				else
				{
					f = false;
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
