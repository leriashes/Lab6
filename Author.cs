using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class Author : Person
	{
		private String country; //Страна

		static Exception ex;

		//Конструктор
		public Author()
		{
			full_name = "Иванов Иван Иванович";
			birth = new Date();
			country = "Россия";
		}

		//Конструктор с параметром
		public Author(String full_name, Date birth_date, String country)
		{
			this.full_name = full_name;
			birth = new Date(birth_date);
			this.country = country;
		}

		//Конструктор с параметром
		public Author(String full_name, int day, int month, int year, String country)
		{
			this.full_name = full_name;
			birth = new Date(0, 0, 0, day, month, year);
			this.country = country;
		}

		public override void Init(string full_name, Date birth_date)
		{
			this.full_name = full_name;
			birth = new Date(birth_date);
		}

		//Инициализация значений всех полей
		public void Init(String full_name, Date birth_date, String country)
		{
			this.full_name = full_name;
			birth = new Date(birth_date);
			this.country = country;
		}

		//Инициализация значений всех полей
		public void Init(String full_name, int day, int month, int year, String country)
		{
			this.full_name = full_name;
			birth.Init(0, 0, 0, day, month, year);
			this.country = country;
		}

		//Ввод значений всех полей
		public void Read()
		{
			bool f = true;

			Console.Write("Введите ФИО автора: ");
			do
			{
				try
				{
					full_name = Console.ReadLine();

					for (int i = 0; i < full_name.Length; i++)
					{
						if (full_name.Substring(i, 1) == " ")
						{
							if (i == 0 || i < full_name.Length - 1 && full_name.Substring(i + 1, 1) == " " || i == full_name.Length - 1)
							{
								full_name = full_name.Substring(0, i) + full_name.Substring(i + 1, full_name.Length - i - 1);
								i--;
							}
						}
					}

					if (full_name.Length == 0)
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

			Console.WriteLine("\nДата рождения");
			birth.ReadDate();

			f = true;
			Console.Write("\nВведите страну происхождения автора: ");
			do
			{
				try
				{
					country = Console.ReadLine();

					for (int i = 0; i < country.Length; i++)
					{
						if (country.Substring(i, 1) == " ")
						{
							if (i == 0 || i < country.Length - 1 && country.Substring(i + 1, 1) == " " || i == country.Length - 1)
							{
								country = country.Substring(0, i) + country.Substring(i + 1, country.Length - i - 1);
								i--;
							}
						}
					}

					if (country.Length == 0)
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

		//Вывод значений полей в выбранном формате
		public void Display(String format)
		{
			String[] form = { "FullName", "FullName (Country)", "FullName (BirthDate)", "all" };
			bool f = true;

			Console.Write($"{full_name} ");

			for (int i = 0; i < 4 && f; i++)
			{
				if (String.Compare(format, form[i]) == 0)
				{
					if (i == 1)
					{
						Console.Write($"({country})");
					}
					else if (i == 2)
					{
						Console.Write("(");
						birth.Display("DD.MM.YYYY");
						Console.Write(")");
					}

					if (i < 3)
					{
						i = 4;
					}
				}

				if (i == 3)
				{
					f = false;
				}
			}

			if (!f)
			{
				Console.Write("(");
				birth.Display("DD.MM.YYYY");
				Console.Write($", {country})");
			}
		}

		public override String ToString()
		{
			return full_name + " (" + birth + ", " + country + ")";
		}

		//Проверка родился ли автор в указанной стране
		public bool BornIn(String country)
		{
			bool result = false;

			if (String.Compare(this.country, country) == 0)
			{
				result = true;
			}

			return result;
		}

		public override String About()
		{
			return this.ToString();
		}
	}
}
