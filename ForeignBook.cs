using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class ForeignBook : Book
	{
		private String language;

		public ForeignBook()
		{
			language = "Английский";
		}

		public ForeignBook(String language)
		{
			this.language = language;
		}
	}
}
