using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class Book
	{
		private static int counter = 0;     //Счётчик книг
		private static int time = 30;		//Время, на которое можно брать книги

		private String title;           //Название книги
		private Author author;      //Автор
		private int pages_number;       //Количество страниц
		private String genre;           //Жанр
		private Reader reader;  //Читатель
		private Publishing publishing;  //Издательство
		private int publ_year;          //Год
		private int id;     //ID книги
		private Date borrow_date;		//Дата взятия книги

		//Свойства
		public static int Counter
		{
			get
			{
				return counter;
			}
		}

		public static int Time
		{
			get
			{
				return time;
			}

			set
			{
				if (value >= 1)
				{
					time = value;
				}
			}
		}

		public static bool BorrowBook(ref Book book, Reader reader, Date date)
		{
			bool result = false;

			if (book.InLib())
			{
				book.AddReader(reader);
				book.borrow_date = date;
				result = true;
			}

			return result;
		}

		public static int BorrowBook(ref Book[] book, int num, Reader reader, Date date)
		{
			int result = 0;

			for (int i = 0; i < num; i++)
			{
				if (BorrowBook(ref book[i], reader, date))
				{
					result += 1;
				}
			}
			return result;
		}

		//Конструктор
		public Book()
		{
			title = "Котофей";
			author = new Author();
			pages_number = 50;
			genre = "Сказки";
			publishing = new Publishing();
			publ_year = 2021;
			counter++;
			id = counter;
			borrow_date = new Date();
		}

		//Конструктор с 1 параметром
		public Book(String title)
		{
			this.title = title;
			author = new Author();
			pages_number = 50;
			genre = "Сказки";
			publishing = new Publishing();
			publ_year = 2021;
			counter++;
			id = counter;
			borrow_date = new Date();
		}

		//Конструктор с параметром
		public Book(String title, Author author, int pages_number, String genre, Publishing publishing, int publication_year)
		{
			this.title = title;
			this.author = author;
			this.pages_number = Math.Abs(pages_number);
			this.genre = genre;
			this.publishing = publishing;
			this.publ_year = Math.Abs(publication_year);
			counter++;
			id = counter;
			borrow_date = new Date();
		}

		//Конструктор с параметром
		public Book(String title, Author author, int pages_number, String genre, Reader reader, Publishing publishing, int publication_year)
		{
			this.title = title;
			this.author = author;
			this.pages_number = Math.Abs(pages_number);
			this.genre = genre;
			this.AddReader(reader);
			this.publishing = publishing;
			this.publ_year = Math.Abs(publication_year);
			counter++;
			id = counter;
			borrow_date = new Date();
		}

		//Инициализация всех полей
		public void Init(String title, Author author, int pages_number, String genre, Publishing publishing, int publication_year)
		{
			this.title = title;
			this.author = author;
			this.pages_number = Math.Abs(pages_number);
			this.genre = genre;
			this.publishing = publishing;
			this.publ_year = Math.Abs(publication_year);
		}

		//Инициализация всех полей
		public void Init(String title, Author author, int pages_number, String genre, Reader reader, Publishing publishing, int publication_year)
		{
			this.title = title;
			this.author = author;
			this.pages_number = Math.Abs(pages_number);
			this.genre = genre;
			this.AddReader(reader);
			this.publishing = publishing;
			this.publ_year = Math.Abs(publication_year);
		}

		//Ввод значений всех полей
		public void Read()
		{
			bool f = true;

			String str;

			Console.Write("Введите название книги: ");
			do
			{
				title = Console.ReadLine();

				if (title.Length == 0)
				{
					Console.Write("\nОшибка ввода! Повторите ввод: ");
				}
				else
				{
					f = false;
				}
			} while (f);

			Console.WriteLine();
			author.Read();

			f = true;
			Console.Write("\nВведите количество страниц в книге: ");
			do
			{
				str = Console.ReadLine();

				try
				{
					pages_number = int.Parse(str);
				}
				catch (FormatException)
				{
					pages_number = 0;
				}

				if (pages_number <= 0)
				{
					Console.Write("\nОшибка ввода! Повторите ввод: ");
				}
				else
				{
					f = false;
				}
			} while (f);

			f = true;
			Console.Write("\nВведите жанр: ");
			do
			{
				genre = Console.ReadLine();

				if (genre.Length == 0)
				{
					Console.Write("\nОшибка ввода! Повторите ввод: ");
				}
				else
				{
					f = false;
				}
			} while (f);

			Console.WriteLine();
			publishing.Read();

			f = true;
			Console.Write("\nВведите год издания книги: ");
			do
			{
				str = Console.ReadLine();

				try
				{
					publ_year = int.Parse(str);
				}
				catch (FormatException)
				{
					publ_year = 0;
				}

				if (publ_year <= 0)
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
			Console.Write($"ID {id}");
			Console.Write($"\nНазвание: \"{title}\"");
			Console.Write($"\nЖанр: {genre}");
			Console.Write($"\nКоличество страниц: {pages_number}");
			Console.Write($"\nГод публикации: {publ_year}");
			Console.Write("\nАвтор: ");
			author.Display("FullName");
			Console.Write("\nИздательство: ");
			publishing.Display();
			if (reader != null)
			{
				Console.Write("\nЧитатель: ");
				reader.Display("[DocNumber] FullName");
				Console.Write("\nДата взятия книги: ");
				borrow_date.Display("DD.MM.YYYY");
				Console.Write("\nСрок сдачи книги: ");
				Date plus = new Date(time, 0, 0);
				(borrow_date + plus).Display("DD.MM.YYYY");
			}
		}

		//Привязка читателя
		public void AddReader(Reader reader)
		{
			this.reader = reader;
		}

		//Проверка находится ли книга в библиотеке
		public bool InLib()
		{
			bool result = false;

			if (reader == null)
			{
				result = true;
			}

			return result;
		}

		//Сравнение читателей книг
		public bool CmpReader(Book second_book)
		{
			return (reader == second_book.reader);
		}

		//Проверка принадлежности книги читателю
		public bool Belongs(Reader reader)
		{
			return this.reader == reader;
		}
	}
}
