using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class Date	//Дата
	{
		private int sec;    //Секунды
		private int min;    //Минуты
		private int hour;   //Часы
		private int day;    //День
		private int month;  //Месяц
		private int year;   //Год

		//Свойства
		public int Sec
		{
			get
			{
				return sec;
			}		

			set
			{
				if (value >= 0 && value < 60)
				{
					sec = value;
				}
			}
		}

		public int Min
		{
			get
			{
				return min;
			}

			set
			{
				if (value >= 0 && value < 60)
				{
					min = value;
				}
			}
		}

		public int Hour
		{
			get
			{
				return hour;
			}

			set
			{
				if (value >= 0 && value < 24)
				{
					hour = value;
				}
			}
		}

		public int Day
		{
			get
			{
				return day;
			}

			set
			{
				if (value >= 0 && value <= 31)
				{
					if (month == 0 || value > 0 && ((month == 4 || month == 6 || month == 9 || month == 11) && value <= 30 || month == 2 && (year % 4 == 0 && value == 29 || value <= 28) || value <= 31))
					{
						day = value;
					}
				}
			}
		}

		public int Month
		{
			get
			{
				return month;
			}

			set
			{
				if (value >= 0 && value <= 12)
				{
					if (day == 0 || day > 0 && ((value == 4 || value == 6 || value == 9 || value == 11) && day <= 30 || value == 2 && (year % 4 == 0 && day == 29 || day <= 28) || (value == 1 || value == 3 || value == 5 || value == 7 || value == 8 || value == 10 || value == 12) && day <= 31))
					{
						month = value;
					}
				}
			}
		}

		public int Year
		{
			get
			{
				return year;
			}

			set
			{
				if (value >= 0 && ((month != 2 || day != 29) || value % 4 == 0))
				{
					year = value;
				}
			}
		}

		//Конструктор
		public Date()
		{
			sec = min = hour = 0;
			day = 1;
			month = 1;
			year = 1900;
		}

		//Конструктор с параметром (только дата)
		public Date(int day, int month, int year)
		{
			sec = min = hour = 0;
			this.day = day;
			this.month = month;
			this.year = year;
		}

		//Конструктор с параметром (дата и время)
		public Date(int seconds, int minutes, int hours, int day, int month, int year)
		{
			sec = seconds;
			min = minutes;
			hour = hours;
			this.day = day;
			this.month = month;
			this.year = year;
		}

		//Конструктор с параметром
		public Date(Date date)
		{
			sec = date.sec;
			min = date.min;
			hour = date.hour;
			day = date.day;
			month = date.month;
			year = date.year;
		}

		//Инициализация всех полей
		public void Init(int seconds, int minutes, int hours, int day, int month, int year)
		{
			sec = seconds;
			min = minutes;
			hour = hours;
			this.day = day;
			this.month = month;
			this.year = year;
		}

		//Ввод времени
		public void ReadTime()
		{
			String stime;
			int[] time = new int[6];
			bool f = true;

			Console.Write("Введите время (в формате hh:mm:ss): ");
			do
			{
				stime = Console.ReadLine();

				if (stime.Length != 8)
				{
					Console.Write("\nОшибка ввода! Повторите ввод: ");
				}
				else
				{
					stime = stime.Substring(0, 2) + stime.Substring(3, 2) + stime.Substring(6, 2);

					try
					{
						time[0] = int.Parse(stime);
					}
					catch (FormatException)
					{
						time[0] = 0;
					}

					for (int i = 0; i < 5 && time[0] > 0; i++)
					{
						time[5 - i] = time[0] % 10;
						time[0] /= 10;
					}

					if (time[0] < 0 || time[0] > 2 ||
					time[1] < 0 || time[1] > 9 || time[0] == 2 && time[1] > 3 ||
					time[2] < 0 || time[2] > 5 ||
					time[3] < 0 || time[3] > 9 ||
					time[4] < 0 || time[4] > 5 ||
					time[5] < 0 || time[5] > 9)
					{
						Console.Write("\nОшибка ввода! Повторите ввод: ");
					}
					else
					{
						f = false;
					}
				}
			} while (f);

			hour = time[0] * 10 + time[1];
			min = time[2] * 10 + time[3];
			sec = time[4] * 10 + time[5];
		}

		//Ввод даты
		public void ReadDate()
		{
			String sdate;
			int[] date = new int[8];
			bool f = true;

			Console.Write("Введите дату (в формате YYYY.MM.DD): ");
			do
			{
				sdate = Console.ReadLine();

				if (sdate.Length != 10)
				{
					Console.Write("\nОшибка ввода! Повторите ввод: ");
				}
				else
				{
					sdate = sdate.Substring(0, 4) + sdate.Substring(5, 2) + sdate.Substring(8, 2);

					try
					{
						date[0] = int.Parse(sdate);
					}
					catch (FormatException)
					{
						date[0] = 0;
					}

					for (int i = 0; i < 7 && date[0] > 0; i++)
					{
						date[7 - i] = date[0] % 10;
						date[0] /= 10;
					}

					if (date[0] < 0 || date[0] > 2 ||
					date[1] < 0 || date[1] > 9 || date[1] != 0 && date[0] > 1 ||
					date[2] < 0 || date[2] > 9 ||
					date[3] < 0 || date[3] > 9 || date[3] == 0 && date[0] == 0 && date[1] == 0 && date[2] == 0 ||
					date[4] < 0 || date[4] > 1 ||
					date[5] < 0 || date[5] > 9 || date[5] > 2 && date[4] == 1 ||
					date[6] < 0 || date[6] > 3 || date[6] == 3 && date[4] == 0 && date[5] == 2 ||
					date[7] < 0 || date[7] > 9 || date[7] == 0 && date[6] == 0 ||
					date[7] == 1 && date[6] == 3 && (date[4] == 0 && date[5] != 1 && date[5] != 3 && date[5] != 5 && date[5] != 7 && date[5] != 8 || date[4] == 1 && date[5] != 0 && date[5] != 2) ||
					date[7] >= 2 && date[7] <= 8 && date[6] > 2 ||
					date[7] == 9 && (date[6] > 2 || date[6] == 2 && date[4] == 0 && date[5] == 2 && (date[2] * 10 + date[3]) % 4 != 0))
					{
						Console.Write("\nОшибка ввода! Повторите ввод: ");
					}
					else
					{
						f = false;
					}
				}
			} while (f);

			year = 0;
			for (int i = 0; i < 4; i++)
			{
				year += date[i] * (int)Math.Pow(10, 3 - i);
			}

			month = date[4] * 10 + date[5];
			day = date[6] * 10 + date[7];

			return;
		}

		//Ввод значений всех полей
		public void Read()
		{
			ReadTime();
			Console.WriteLine();
			ReadDate();
		}

		//Вывод значений всех полей
		public void Display(String format)
		{
			String[] form = { "hh:mm:ss", "hh:mm", "mm:ss", "DD.MM.YYYY", "DD/MM/YYYY", "MM.DD.YYYY", "DD-MM-YYYY", "YYYY-MM-DD", "CompareResult", "CompareResultRU", "all" };
			bool f = true;

			for (int i = 0; i < 11 && f; i++)
			{
				if (String.Compare(format, form[i]) == 0)
				{
					if (i == 0)
					{
						Console.Write("{0:d2}:{1:d2}:{2:d2}", hour, min, sec);
					}
					else if (i == 1)
					{
						Console.Write("{0:d2}:{1:d2}", hour, min);
					}
					else if (i == 2)
					{
						Console.Write("{0:d2}:{1:d2}", min, sec);
					}
					else if (i == 3)
					{
						Console.Write("{0:d2}.{1:d2}.{2:d4}", day, month, year);
					}
					else if (i == 4)
					{
						Console.Write("{0:d2}/{1:d2}/{2:d4}", day, month, year);
					}
					else if (i == 5)
					{
						Console.Write("{0:d2}.{1:d2}.{2:d4}", month, day, year);
					}
					else if (i == 6)
					{
						Console.Write("{0:d2}-{1:d2}-{2:d4}", day, month, year);
					}
					else if (i == 7)
					{
						Console.Write("{0:d4}-{1:d2}-{2:d2}", year, month, day);
					}
					else if (i == 8)
					{
						int k = 0;

						if (year > 0)
						{
							if (year > 1)
							{
								Console.Write("{0:d} years ", year);
							}
							else
							{
								Console.Write("{0:d} year ", year);
							}
							k++;
						}

						if (day > 0)
						{
							if (day > 1)
							{
								Console.Write("{0:d} days ", day);
							}
							else
							{
								Console.Write("{0:d} day ", day);
							}
							k++;
						}

						if (hour > 0)
						{
							if (hour > 1)
							{
								Console.Write("{0:d} hours ", hour);
							}
							else
							{
								Console.Write("{0:d} hour ", hour);
							}
							k++;
						}

						if (min > 0)
						{
							if (min > 1)
							{
								Console.Write("{0:d} minutes ", min);
							}
							else
							{
								Console.Write("{0:d} minute ", min);
							}
							k++;
						}

						if (sec > 0)
						{
							if (sec > 1)
							{
								Console.Write("{0:d} seconds ", sec);
							}
							else
							{
								Console.Write("{0:d} second ", sec);
							}
							k++;
						}

						if (k == 0)
						{
							Console.Write("The time has already come. ");
						}
					}
					else if (i == 9)
					{
						int k = 0;

						if (year > 0)
						{
							Console.Write("{0:d} ", year);
							if (year % 10 == 1 && year % 100 != 11)
							{
								Console.Write("год ");
							}
							else if (year % 10 >= 2 && year % 10 <= 4 && (year % 100 < 12 || year % 100 > 14))
							{
								Console.Write("года ");
							}
							else
							{
								Console.Write("лет ");
							}
							k++;
						}

						if (day > 0)
						{
							Console.Write("{0:d} ", day);
							if (day % 10 == 1 && day % 100 != 11)
							{
								Console.Write("день ");
							}
							else if (day % 10 >= 2 && day % 10 <= 4 && (day % 100 < 12 || day % 100 > 14))
							{
								Console.Write("дня ");
							}
							else
							{
								Console.Write("дней ");
							}
							k++;
						}

						if (hour > 0)
						{
							Console.Write("{0:d} ", hour);
							if (hour % 10 == 1 && hour % 100 != 11)
							{
								Console.Write("час ");
							}
							else if (hour % 10 >= 2 && hour % 10 <= 4 && (hour % 100 < 12 || hour % 100 > 14))
							{
								Console.Write("часа ");
							}
							else
							{
								Console.Write("часов ");
							}
							k++;
						}

						if (min > 0)
						{
							Console.Write("{0:d} ", min);
							if (min % 10 == 1 && min % 100 != 11)
							{
								Console.Write("минута ");
							}
							else if (min % 10 >= 2 && min % 10 <= 4 && (min % 100 < 12 || min % 100 > 14))
							{
								Console.Write("минуты ");
							}
							else
							{
								Console.Write("минут ");
							}
							k++;
						}

						if (sec > 0)
						{
							Console.Write("{0:d} ", sec);
							if (sec % 10 == 1 && sec % 100 != 11)
							{
								Console.Write("секунда ");
							}
							else if (sec % 10 >= 2 && sec % 10 <= 4 && (sec % 100 < 12 || sec % 100 > 14))
							{
								Console.Write("секунды ");
							}
							else
							{
								Console.Write("секунд ");
							}
							k++;
						}

						if (k == 0)
						{
							Console.Write("Это время уже наступило. ");
						}
					}

					if (i < 10)
					{
						i = 11;
					}
				}

				if (i == 10)
				{
					f = false;
				}
			}

			if (!f)
			{
				Console.Write("{0:d2}:{1:d2}:{2:d2} {3:d2}.{4:d2}.{5:d4}", hour, min, sec, day, month, year);
			}

		}

		//Текущая дата
		public Date Now()
		{
			DateTime today = DateTime.Now;
			Init(today.Second, today.Minute, today.Hour, today.Day, today.Month, today.Year);
			return this;
		}

		//Сравнение дат
		public Date Compare(Date end_date)
		{
			Date result = new Date();

			result.year = end_date.year - year;

			if (month > end_date.month)
			{
				for (int i = 1; i < 13; i++)
				{
					if (i >= month || i < end_date.month)
					{
						if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
						{
							result.day += 31;
						}
						else if (i == 2)
						{
							result.day += 28;
							if (i >= month && year % 4 == 0 || i < end_date.month && end_date.year % 4 == 0)
							{
								result.day++;
							}
						}
						else
						{
							result.day += 30;
						}
					}

				}

				if (result.year > 0)
				{
					result.year--;
				}
			}
			else if (month == end_date.month)
			{
				result.day = end_date.day - day;
				if (result.day < 0)
				{
					result.year--;
					for (int i = 1; i < 13; i++)
					{
						if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
						{
							result.day += 31;
						}
						else if (i == 2)
						{
							result.day += 28;
							if (i >= month && year % 4 == 0 || i < end_date.month && end_date.year % 4 == 0)
							{
								result.day++;
							}
						}
						else
						{
							result.day += 30;
						}
					}
				}

			}
			else
			{
				for (int i = 1; i < 13; i++)
				{
					if (i >= month && i < end_date.month)
					{
						if (i == 1 || i == 3 || i == 5 || i == 7 || i == 8 || i == 10 || i == 12)
						{
							result.day += 31;
						}
						else if (i == 2)
						{
							result.day += 28;
							if (i >= month && year % 4 == 0 || i < end_date.month && end_date.year % 4 == 0)
							{
								result.day++;
							}
						}
						else
						{
							result.day += 30;
						}
					}

				}

				result.day += end_date.day - day - 1;
			}

			result.month = 0;

			if (result.day >= 0)
			{
				result.hour = 24 - hour + end_date.hour;
				if (result.day + result.year == 0)
				{
					result.hour -= 24;
				}
				else
				{
					if (result.hour >= 24)
					{
						result.hour -= 24;
					}
					else
					{
						result.day--;
					}
				}

				result.min = 60 - min + end_date.min;
				if (result.hour + result.day + result.year == 0)
				{
					result.min -= 60;
				}
				else
				{
					if (result.min >= 60)
					{
						result.min -= 60;
					}
					else
					{
						result.hour--;
					}
				}

				result.min = 60 - min + end_date.min;
				if (result.hour + result.day + result.year == 0)
				{
					result.min -= 60;
				}
				else
				{
					if (result.min >= 60)
					{
						result.min -= 60;
					}
					else
					{
						result.hour--;
					}
				}

				result.sec = 60 - sec + end_date.sec;
				if (result.min + result.hour + result.day + result.year == 0)
				{
					result.sec -= 60;
				}
				else
				{
					if (result.sec >= 60)
					{
						result.sec -= 60;
					}
					else
					{
						result.min--;
					}
				}
			}

			if (result.day < 0 || result.year < 0 || result.hour < 0 || result.min < 0 || result.sec < 0)
			{
				result.year = result.day = result.hour = result.min = result.sec = 0;
			}

			return result;
		}

		//Прибавление времени к дате
		public Date Add(Date add_date)
		{
			Date result = new Date(sec + add_date.sec, min + add_date.min, hour + add_date.hour, day + add_date.day, month + add_date.month, year + add_date.year);

			while (result.sec >= 60)
			{
				result.sec -= 60;
				result.min += 1;
			}

			while (result.min >= 60)
			{
				result.min -= 60;
				result.hour += 1;
			}

			while (result.hour >= 24)
			{
				result.hour -= 24;
				result.day += 1;
			}

			bool f = true;

			while (f)
			{
				if (result.day > 31 && (result.month == 1 || result.month == 3 || result.month == 5 || result.month == 7 || result.month == 8 || result.month == 10 || result.month == 12))
				{
					result.day -= 31;
				}
				else if (result.month == 2 && result.day > 28)
				{
					if (result.day > 29 && result.year % 4 == 0)
						result.day -= 29;
					else
						result.day -= 28;
				}
				else if (result.day > 30)
				{
					result.day -= 30;
				}
				else
				{
					f = false;
				}

				if (f)
				{
					result.month++;

					if (result.month >= 13)
					{
						result.month -= 12;
						result.year++;
					}
				}
			}

			return result;
		}

		//Проверка является ли дата годовщиной другой
		public bool IsAnniversary(Date second_date)
		{
			return (day == second_date.day && month == second_date.month && year <= second_date.year);
		}

		public void TimeToSec(ref int time)
		{
			time = sec + (min + hour * 60) * 60;
		}

		public void TimeToDays(out int time)
		{
			time = day;

			for(int i = 1; i < month; i++)
			{
				if (i == 2)
				{
					time += 28;

					if (year % 4 == 0)
					{
						time++;
					}
				}
				else if (i == 4 || i == 6 || i == 9 || i == 11)
				{
					time += 30;
				}
				else
				{
					time += 31;
				}
			}

			for(int i = 1; i < year; i++)
			{
				time += 365;

				if (i % 4 == 0)
				{
					time++;
				}
			}
		}

		//Перегрузка оператора + Date+Date
		public static Date operator +(Date a, Date b)
		{
			return a.Add(b);
		}

		//Перегрузка оператора + int+Date
		public static Date operator +(Date a, int i)
		{
			Date b = new Date(i, 0, 0, 0, 0, 0);
			return a.Add(b);
		}

		//Перегрузка оператора + Date+int
		public static Date operator +(int i, Date b)
		{
			Date a = new Date(i, 0, 0, 0, 0, 0);
			return a.Add(b);
		}

		//Перегрузка оператора ++
		public static Date operator ++(Date date)
		{
			Date a = new Date(1, 0, 0);
			return date.Add(a);
		}
	}
}
