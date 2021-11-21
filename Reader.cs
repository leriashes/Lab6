using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class Reader
	{
		private String full_name;   //ФИО
		private Date birth;         //Дата рождения
		private Address address;    //Адрес
		private String doc_number;      //Номер документа, удостоверяющего личность

		static Exception ex;

		//Конструктор
		public Reader()
		{
			full_name = "Иванов Иван Иванович";
			birth = new Date();
			address = new Address();
			doc_number = "01 10 123456";
		}

		//Конструктор с параметром
		public Reader(String full_name, Date birth_date, Address address, String doc_number)
		{
			this.full_name = full_name;
			birth = new Date(birth_date);
			this.address = address;
			this.doc_number = doc_number;
		}

		//Конструктор с параметром 
		public Reader(String full_name, Date birth_date, Address address, int doc_number)
		{
			this.full_name = full_name;
			birth = new Date(birth_date);
			this.address = address;
			this.doc_number = doc_number.ToString();
		}

		//Инициализация всех полей
		public void Init(String full_name, Date birth_date, Address address, String doc_number)
		{
			this.full_name = full_name;
			birth = new Date(birth_date);
			this.address = address;
			this.doc_number = doc_number;
		}

		//Инициализация всех полей
		public void Init(String full_name, Date birth_date, Address address, int doc_number)
		{
			this.full_name = full_name;
			birth = new Date(birth_date);
			this.address = address;
			this.doc_number = doc_number.ToString();
		}

		//Ввод всех полей
		public void Read()
		{
			bool f = true;

			Console.Write("Введите ФИО читателя: ");
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

			Console.WriteLine("\nАдрес проживания");
			address.Read();

			f = true;
			Console.Write("\nВведите номер документа, удостовряющего личность: ");
			do
			{
				try
				{
					doc_number = Console.ReadLine();

					for (int i = 0; i < doc_number.Length; i++)
					{
						if (doc_number.Substring(i, 1) == " ")
						{
							if (i == 0 || i < doc_number.Length - 1 && doc_number.Substring(i + 1, 1) == " " || i == doc_number.Length - 1)
							{
								doc_number = doc_number.Substring(0, i) + doc_number.Substring(i + 1, doc_number.Length - i - 1);
								i--;
							}
						}
					}

					if (doc_number.Length == 0)
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
			String[] form = { "FullName", "[DocNumber] FullName", "FullName (BirthDate)", "all" };
			bool f = true;

			for (int i = 0; i < 4 && f; i++)
			{
				if (String.Compare(format, form[i]) == 0)
				{
					if (i == 0)
					{
						Console.Write($"{full_name} ");
					}
					else if (i == 1)
					{
						Console.Write($"[{doc_number}] {full_name} ");
					}
					else if (i == 2)
					{
						Console.Write($"{full_name} (");
						birth.Display("DD.MM.YYYY");
						Console.Write(") ");
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
				Console.Write($"[{doc_number}] {full_name} (Дата рождения: ");
				birth.Display("DD.MM.YYYY");
				Console.Write(". Адрес проживания: ");
				address.Display();
				Console.Write(") ");
			}
		}

		//Проверка является ли день днём рождения читателя
		public bool IsBirthday(Date day)
		{
			return birth.IsAnniversary(day);
		}
	}
}
