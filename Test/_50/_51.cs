using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _51
	{
		public string solution(int[] food)
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringBuilder stringBuilder2 = new StringBuilder();

			int stock;
			for(int i=1;  i<food.Length; i++)
			{
				stock = food[i] / 2;
				for(int j=0; j<stock;j++)
				{
					stringBuilder.Append(i);
				}
			}

			for (int i = food.Length-1 ; i >=1 ; i--)
			{
				stock = food[i] / 2;
				for (int j = 0; j < stock; j++)
				{
					stringBuilder2.Append(i);
				}
			}

			return stringBuilder.ToString() + "0" + stringBuilder2.ToString();
		}
	}
}
