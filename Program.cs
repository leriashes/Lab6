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

			//Работа со свойствами
			Console.WriteLine("\nРабота со свойствами объекта date_1");
			date_1.Sec = 121;
			Console.WriteLine("date_1.sec = ", date_1.Sec);
			date_1.Sec = 4;
			Console.WriteLine("date_1.sec = {0:d}\n", date_1.Sec);

			date_1.Min = 60;
			Console.WriteLine("date_1.min = {0:d}", date_1.Min);
			date_1.Min = 12;
			Console.WriteLine("date_1.min = {0:d}\n", date_1.Min);

			date_1.Hour = 28;
			Console.WriteLine("date_1.hour = {0:d}", date_1.Hour);
			date_1.Hour = 13;
			Console.WriteLine("date_1.hour = {0:d}\n", date_1.Hour);

			date_1.Day = -5;
			Console.WriteLine("date_1.day = {0:d}", date_1.Day);
			date_1.Day = 30;
			Console.WriteLine("date_1.day = {0:d}\n", date_1.Day);

			date_1.Month = 2;
			Console.WriteLine("date_1.month = {0:d}", date_1.Month);
			date_1.Month = 12;
			Console.WriteLine("date_1.month = {0:d}\n", date_1.Month);

			date_1.Year = 2005;
			Console.WriteLine("date_1.year = {0:d}", date_1.Year);

			Console.Write("\ndate_1 = ");
			date_1.Display("all");

			//Возврат значения через ref - переменная a должна быть проинициализированна перед вызовом метода
			int a = 0;
			date_1.TimeToSec(ref a);
			Console.WriteLine("\n\na = {0:d}", a);

			//Возврат значения через out - переменная b может быть не проинициализированна перед вызовом метода
			int b;
			date_1.TimeToDays(out b);
			Console.WriteLine("\nb = {0:d}", b);

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
			date_2.Now().Display("all");

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

			//Прибавление времени к дате
			Console.Write("\n\nПрибавление времени date_3 к дате date_1 (Date + Date): ");
			(date_1 + date_3).Display("all");
			Console.WriteLine();

			//Прибавление времени к дате
			Console.Write("\n\nПрибавление 2 часов 30 минут к дате date_1 (Date + Int): ");
			(date_1 + 9000).Display("all");
			Console.WriteLine();

			//Прибавление времени к дате
			Console.Write("\n\nПрибавление 2 часов 30 минут к дате date_1 (Int + Date): ");
			(9000 + date_1).Display("all");
			Console.WriteLine();

			//Прибавление времени к дате
			Console.Write("\n\nПрибавление 1 дня к дате date_1 (++Date): ");
			(++date_1).Display("all");
			Console.WriteLine();

			//Прибавление времени к дате
			Console.Write("\n\nПрибавление 1 дня к дате date_1 (Date++): ");
			(date_1++).Display("all");
			Console.Write("\nПосле выполнения операции: ");
			(date_1).Display("all");
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



			//Работа с объектами класса Author
			Console.WriteLine("\n\n\nРабота с объектами класса Author");
			Author author_1 = new Author(); //Создание через конструктор без параметров

			//Создание через конструкторы с параметрами
			Author author_2 = new Author("Петров Пётр Петрович", date_1, "Украина");
			Author author_3 = new Author("Сидорова Светлана Сергеевна", 12, 12, 1972, "Беларусь");

			//Печать созданных объектов
			Console.Write("\nПечать данных объектов\nauthor_1 = {0:s}", author_1);
			Console.Write("\nauthor_2 = {0:s}", author_2);
			Console.Write("\nauthor_3 = {0:s}\n", author_3);

			//Ввод значений всех полей объекта
			Console.WriteLine("\n\nВвод значений всех полей объекта");

			author_1.Read();
			Console.Write("\nauthor_1 = {0:s}\n", author_1);

			//Вывод значений полей в выбранном формате
			Console.Write("\n\nВывод значений полей в выбранном формате (помимо полного вывода)\nauthor_1 (FullName) = ");
			author_1.Display("FullName");
			Console.Write("\nauthor_1 (FullName (Country)) = ");
			author_1.Display("FullName (Country)");
			Console.Write("\nauthor_1 (FullName (BirthDate)) = ");
			author_1.Display("FullName (BirthDate)");
			Console.WriteLine();

			//Инициализация значений
			Console.Write("\n\nИнициализация значений");
			author_2.Init("Паркер Энн", date_1, "США");
			Console.Write("\nauthor_2 = {0:s}\n", author_2);

			//Проверка родился ли автор в заданной стране
			Console.Write("\n\nПроверка родился ли автор в заданной стране\n{0:s} и страна Россия", author_1);
			if (author_1.BornIn("Россия"))
			{
				Console.WriteLine(": да.");
			}
			else
			{
				Console.WriteLine(": нет.");
			}



			//Работа с объектами класса Address
			Console.WriteLine("\n\n\nРабота с объектами класса Address");

			Address address_1 = new Address();  //Создание через конструктор без параметров
			Address address_2 = new Address("г. Новосибирск", "ул. Сиреневая", 12, 4);      //Создание через конструкторы с параметрами

			//Печать созданных объектов
			Console.Write("\nПечать данных объектов\naddress_1 = {0:s}", address_1);
			Console.Write("\naddress_2 = {0:s}\n", address_2);

			//Ввод значений всех полей объекта
			Console.WriteLine("\n\nВвод значений всех полей объекта");

			address_1.Read();
			Console.Write("\naddress_1 = {0:s}\n", address_1);

			//Инициализация значений
			Console.Write("\n\nИнициализация значений");
			address_1.Init("г. Троицк", "ул. Текстильщиков", 6, 2);
			Console.Write("\naddress_1 = {0:s}\n", address_1);

			//Проверка совпадения города
			Console.Write("\n\nПроверка совпадения города\n{0:s} и г. Барнаул", address_1);
			if (address_1.City("г. Барнаул"))
			{
				Console.WriteLine(": да.");
			}
			else
			{
				Console.WriteLine(": нет.");
			}



			//Работа с объектами класса Reader
			Console.WriteLine("\n\n\nРабота с объектами класса Reader");

			Reader reader_1 = new Reader(); //Создание через конструктор без параметров

			//Создание через конструкторы с параметрами
			Reader reader_2 = new Reader("Петров Пётр Петрович", date_1, address_1, "0110 120954");
			Reader reader_3 = new Reader("Сидорова Светлана Сергеевна", date_2, address_2, 987654);

			//Печать созданных объектов
			Console.Write("\nПечать данных объектов\nreader_1 = {0:s}", reader_1);
			Console.Write("\nreader_2 = {0:s}", reader_2);
			Console.Write("\nreader_3 = {0:s}\n", reader_3);

			//Ввод значений всех полей объекта
			Console.WriteLine("\n\nВвод значений всех полей объекта");
			reader_1.Read();
			Console.Write("\nreader_1 = {0:s}\n", reader_1);

			//Вывод значений полей в выбранном формате
			Console.Write("\n\nВывод значений полей в выбранном формате (помимо полного вывода)\nreader_1 (FullName) = ");
			reader_1.Display("FullName");
			Console.Write("\nreader_1 ([DocNumber] FullName) = ");
			reader_1.Display("[DocNumber] FullName");
			Console.Write("\nreader_1 (FullName (BirthDate)) = ");
			reader_1.Display("FullName (BirthDate)");
			Console.WriteLine();

			//Инициализация значений
			Console.Write("\n\nИнициализация значений");
			reader_1.Init("Кузнецов Кирилл Корнеевич", date_3, address_1, "0112 765423");
			Console.Write("\nreader_1 = {0:s}\n", reader_1);

			//Проверка является ли дата днём рождения читателя
			Console.Write("\n\nПроверка является ли дата днём рождения читателя\n{0:s} и {1:s}", reader_3, date_3);
			if (reader_3.IsBirthday(date_3))
			{
				Console.WriteLine(": да.");
			}
			else
			{
				Console.WriteLine(": нет.");
			}



			//Работа с объектами класса Publishing
			Console.WriteLine("\n\n\nРабота с объектами класса Publishing");

			Publishing publishing_1 = new Publishing(); //Создание через конструктор без параметров
			Publishing publishing_2 = new Publishing("Издательство №2", "г. Барнаул");      //Создание через конструктор с параметрами

			//Печать созданных объектов
			Console.Write("\nПечать данных объектов\npublishing_1 = {0:s}", publishing_1);
			Console.Write("\npublishing_2 = {0:s}\n", publishing_2);

			//Ввод значений всех полей объекта
			Console.WriteLine("\n\nВвод значений всех полей объекта");
			publishing_1.Read();
			Console.Write("\npublishing_1 = {0:s}\n", publishing_1);

			//Инициализация значений
			Console.Write("\n\nИнициализация значений");
			publishing_1.Init("Паркер", "г. Вашингтон");
			Console.Write("\npublishing_1 = {0:s}\n", publishing_1);

			//Проверка находится ли издательство в заданном городе
			Console.Write("\n\nПроверка находится ли издательство в заданном городе\n{0:s} и г. Москва", publishing_1);
			if (publishing_1.IsHere("г. Москва"))
			{
				Console.WriteLine(": да.");
			}
			else
			{
				Console.WriteLine(": нет.");
			}



			//Работа с объектами класса Book
			Console.WriteLine("\n\n\nРабота с объектами класса Book");

			Book book_1 = new Book();   //Создание через конструктор без параметров

			//Создание через конструкторы с параметрами
			Book book_2 = new Book("Новый мир");
			Book book_3 = new Book("Петька и Васька", author_3, 76, "Рассказы", reader_1, publishing_1, 2019);

			//Печать созданных объектов
			Console.Write("\nПечать данных  объектов\nbook_1 {0:s}", book_1);
			Console.Write("\n\nbook_2 {0:s}", book_2);
			Console.Write("\n\nbook_3 {0:s}\n", book_3);

			//Ввод значений всех полей объекта
			Console.WriteLine("\n\nВвод значений всех полей объекта");

			book_1.Read();
			Console.Write("\n\nbook_1 {0:s}\n", book_1);

			//Инициализация значений
			Console.Write("\n\nИнициализация значений");
			book_1.Init("Петька и Кот", author_3, 65, "Ужасы", publishing_1, 2005);
			Console.Write("\nbook_1 {0:s}", book_1);

			book_3.Init("Васька и Пёс", author_2, 124, "Комедия", reader_3, publishing_2, 2012);
			Console.Write("\n\nbook_3 {0:s}\n", book_3);

			//Привязка читателя
			book_2.AddReader(reader_1);
			Console.Write("\n\nПривязка читателя\nbook_2 {0:s}\n", book_2);

			//Проверка принадлежности книги читателю
			Console.Write("\n\nПроверка принадлежности книги читателю\n{0:s}\n\nи \n\n", book_2);
			reader_1.Display("Full_name");
			if (book_2.Belongs(reader_1))
			{
				Console.WriteLine("\n\nкнига у этого читателя.");
			}
			else
			{
				Console.WriteLine("\n\nкнига не у этого читателя.");
			}

			//Сравнение читателей книг
			Console.Write("\n\nСравнение читателей книг\n{0:s}\n\nи \n\n{1:s}", book_3, book_2);
			if (book_3.CmpReader(book_2))
			{
				Console.WriteLine("\n\nодин и тот же читатель.");
			}
			else
			{
				Console.WriteLine("\n\nразные читатели.");
			}

			//Отвязка читателя
			book_2.AddReader(null);
			Console.Write("\n\nОтвязка читателя\nbook_2 {0:s}\n", book_2);

			//Проверка принадлежности книги читателю
			Console.Write("\n\nПроверка принадлежности книги читателю\n{0:s}\n\nи \n\n", book_2);
			reader_1.Display("Full_name");
			if (book_2.Belongs(reader_1))
			{
				Console.WriteLine("\n\nкнига у этого читателя.");
			}
			else
			{
				Console.WriteLine("\n\nкнига не у этого читателя.");
			}

			Console.WriteLine($"\n\nКниг в бибилиотеке: {Book.Counter}");

			//Работа с массивами
			Book[] books_mas1 = new Book[2];

			for (int i = 0; i < 2; i++)
			{
				books_mas1[i] = new Book("Новая книга");
			}

			List<Book> books_mas2 = new List<Book>();

			//Вывод объектов

			//Первый массив
			Console.WriteLine("\n\nbooks_mas1");
			foreach (Book book in books_mas1)
			{
				book.Display();
				Console.WriteLine("\n");
			}

			//Второй массив
			Console.WriteLine("\nbooks_mas2");
			books_mas2.Add(new Book("Васька и Пёс", author_2, 124, "Комедия", reader_3, publishing_2, 2012));
			books_mas2.Add(book_2);
			foreach (Book book in books_mas2)
			{
				book.Display();
				Console.WriteLine("\n");
			}

			books_mas2.RemoveAt(0);

			Console.WriteLine("\nbooks_mas2");
			foreach (Book book in books_mas2)
			{
				book.Display();
				Console.WriteLine("\n");
			}

			Console.WriteLine($"\n\nКниг в бибилиотеке: {Book.Counter}");

			Console.Write("\nНажмите любую клавишу...");
			Console.ReadKey();

			Book kniga = new Book();
			Console.Write($"\n\nКниг в библиотеке:{Book.Counter} \nВремя, на которое можно брать книги: {Book.Time}");
			Book.Time = 14;
			Book[] knigi = new Book[3];
			for (int i = 0; i < 3; i++)
			{
				knigi[i] = new Book();
			}
			Console.Write($"\n\nКниг в библиотеке:{Book.Counter} \nВремя, на которое можно брать книги: {Book.Time}\n\n");

			Book.BorrowBook(ref kniga, reader_1, Date.Today());
			kniga.Display();
			Console.Write($"\n\nКоличество выданных книг читателю reader_3: {Book.BorrowBook(ref knigi, 2, reader_3, Date.Today())}\n\n");
			Console.Write($"\n\nКоличество выданных книг читателю reader_2: {Book.BorrowBook(ref knigi, 3, reader_2, Date.Today())}\n\n");

			for (int i = 0; i < 3; i++)
			{
				Console.Write("\n\n");
				knigi[i].Display();
			}

			Console.Write("\nНажмите любую клавишу...");
			Console.ReadKey();

			//Работа с одномерным массивом
			Book[] odnm_mas = new Book[3];
			for (int i = 0; i < 3; i++)
			{
				odnm_mas[i] = new Book();
			}
			Console.Write($"Работа с одномерным массивом\nКниг в библиотеке:{Book.Counter} ");

			for (int i = 0; i < 3; i++)
			{
				Console.Write($"\n\nodnm_mas[{i}] ");
				odnm_mas[i].Display();
			}

			Console.Write("\n\nВведите индекс элемента массива для ввода: ");
			int k, d;
			String index;
			do
			{
				Console.Write("\n\nВведите индекс элемента массива для ввода: ");
				index = Console.ReadLine();
				try
				{
					k = int.Parse(index);
				}
				catch (FormatException)
				{
					k = 0;
				}
			} while (k < 0 || k > 2);

			Console.Write($"{k}\n\nВвод информации о книге odnm_mas[{k}]\n");
			odnm_mas[k].Read();

			Console.Write($"\n\nodnm_mas[{k}] ");
			odnm_mas[k].Display();

			//Работа с двумерным массивом
			Book[,] dvum_mas = new Book[2,2];
			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					dvum_mas[i,j] = new Book();
				}
			}
			Console.Write($"Работа с двумерным массивом\nКниг в библиотеке:{Book.Counter} ");

			for (int i = 0; i < 2; i++)
			{
				for (int j = 0; j < 2; j++)
				{
					Console.Write($"\n\ndvum_mas[{i},{j}] ");
					dvum_mas[i,j].Display();
				}
			}

			do
			{
				Console.Write("\n\nВведите номер строки двумерного массива: ");
				index = Console.ReadLine();
				try
				{
					k = int.Parse(index);
				}
				catch (FormatException)
				{
					k = 0;
				}
			} while (k < 0 || k > 1);
			Console.Write($"{k}");

			do
			{
				Console.Write("\n\nВведите номер столбца двумерного массива: ");
				index = Console.ReadLine();
				try
				{
					d = int.Parse(index);
				}
				catch (FormatException)
				{
					d = 0;
				}
			} while (d < 0 || d > 1);

			Console.Write($"{d}\n\nВвод информации о книге dvum_mas[{k},{d}]\n");
			dvum_mas[k,d].Read();

			Console.Write($"\n\ndvum_mas[{k},{d}]");
			dvum_mas[k,d].Display();

			Date fdate = new Date(28, 11, 2001);
			Address faddress = new Address();
			Reader freader = new Reader("Шишкова Валентина Алексеевна", fdate, faddress, 123456789);
			Author fauthor = new Author("Сьюэлл Анна", date_1, "Великобритания");
			Publishing fpublishing = new Publishing();

			ForeignBook fbook = new ForeignBook("Good Morning", fauthor, 345, "Фантастика", freader, fpublishing, 2021, "Английский");
			ForeignBook fbook1 = new ForeignBook();

			fbook1.Init("Black Beauty", fauthor, 289, "Рассказы", publishing_1, 2019, "Английский");

			book_1 = (Book)book_2.Clone();
			Console.Write("\nbook_1 {0:s}\n", book_1);
			Console.Write("\nbook_2 {0:s}\n", book_2);
			book_2.Init("Black Beauty", author_1, 289, "Рассказы", publishing_1, 2019);
			Console.Write("\nbook_2 {0:s}\n", book_2);
			Console.Write("\nbook_1 {0:s}\n", book_1);
		}
	}
}
