using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	abstract class Person
	{
		protected String full_name;
		protected Date birth;

		public abstract void Init(String full_name, Date birth_date);
		public abstract String About();
	}
}
