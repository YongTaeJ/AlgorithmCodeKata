using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _55
	{
		public string solution(string[] cards1, string[] cards2, string[] goal)
		{
			string answer = "Yes";
			int c1Count = 0, c2Count = 0;

			for(int i=0; i < goal.Length; i++)
			{
				if (c1Count == cards1.Length)
					c1Count = 0;
				if (c2Count == cards2.Length)
					c2Count = 0;

				if (cards1[c1Count] == goal[i]) c1Count++;
				else if (cards2[c2Count] == goal[i]) c2Count++;
				else answer = "No";
			}

			return answer;
		}
	}
}
