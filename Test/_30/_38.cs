using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _38
	{
		public void solution()
		{
			string[] input = Console.ReadLine().Split(' ');

			int x = int.Parse(input[0]);
			int y = int.Parse(input[1]);

			for (int i = 0; i < y; i++)
			{
				for (int j = 0; j < x; j++)
				{
					Console.Write('*');
				}
				Console.WriteLine();
			}
		}
	}
}
