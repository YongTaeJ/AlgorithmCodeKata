using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _42
	{
		public int solution(int[] number)
		{
			int length = number.Length;

			int first, second, third;
			int count = 0;

			for(int i=0; i<length; i++)
			{
				first = number[i];
				for(int j = i+1; j<length; j++)
				{
					second = number[j];
					for(int k =j+1; k<length; k++)
					{
						third = number[k];
						if( first+second+third == 0 )
						{
							count++;
						}
					}
				}
			}

			return count;
		}
	}
}
