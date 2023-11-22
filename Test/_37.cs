using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _37
	{
		public int[,] solution(int[,] arr1, int[,] arr2)
		{
			int row = arr1.GetLength(0);
			int collum = arr1.GetLength(1);
			int[,] answer = new int[row, collum];

			for(int i=0; i <row; i++)
			{
				for(int j=0; j < collum; j++)
				{
					answer[i,j] = arr1[i,j] + arr2[i,j];
				}
			}

			return answer;
		}
	}
}
