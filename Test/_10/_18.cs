using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _18
	{
		public int solution(string s)
		{
			string input = Console.ReadLine();

			bool NF = false;
			int sum = 0;

			foreach(char c in input)
			{
				sum *= 10;

				if(c == '-')
					NF = true;

				if(c >= '0' && c <= '9')
				{
					sum += (int)(c - '0');
				}
			}
			if (NF)
				sum *= -1;

			return sum;
		}
	}
}
