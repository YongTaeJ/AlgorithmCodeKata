using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _43
	{
		public int solution(string t, string p)
		{
			// p의 갯수만큼 t를 잘라서 값을 확인한다.

			int compareValue = int.Parse(p);
			int tempInt;
			int count = 0;

			for(int i=0; i < t.Length - p.Length + 1; i++)
			{
				// i -> p 길이만큼 자르기
				tempInt = int.Parse(t.Substring(i, p.Length));
				if (tempInt <= compareValue)
				{
					count++;
				}
			}

			return count;
		}
	}
}
