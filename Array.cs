using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
	class Array<T> where T:Book
	{
		public T[] data;
		public int size;

		public Array(T[] m)
		{
			data = m;
			size = m.Length;
		}

		public void Read()
		{
			for (int i = 0; i < size; i++)
			{
				data[i].Read();
				Console.Write("\n\n");
			}
		}

		public bool AllInLib()
		{
			bool result = false;
			int k = 0;

			for (int i = 0; i < size; i++)
			{
				if (data[i].InLib())
				{
					k += 1;
				}
			}

			if (k == size)
			{
				result = true;
			}

			return result;
		}
	}
}
