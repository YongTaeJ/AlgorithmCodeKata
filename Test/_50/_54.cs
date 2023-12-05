using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _54
	{
		public string solution(int a, int b)
		{
			int day = 4; // 1월 1일은 금요일

			// a월의 1일은?
			for (int i = 2; i <= a; i++)
			{
				// 이전 달이 몇일이었나?
				switch(i-1)
				{
					// 31일
					case 1:
					case 3:
					case 5:
					case 7:
					case 8:
					case 10:
					case 12:
						day += 31;
						break;
					// 30일
					case 4:
					case 6:
					case 9:
					case 11:
						day += 30;
						break;
					// 29일
					case 2:
						day += 29;
						break;
				}
			}
			day += b - 1;

			// 0 월요일 ~ 6 일요일
			day %= 7;

			string dayOfWeek = "";

			switch(day)
			{
				case 0:
					dayOfWeek = "MON";
					break;
				case 1:
					dayOfWeek = "TUE";
					break;
				case 2:
					dayOfWeek = "WED";
					break;
				case 3:
					dayOfWeek = "THU";
					break;
				case 4:
					dayOfWeek = "FRI";
					break;
				case 5:
					dayOfWeek = "SAT";
					break;
				case 6:
					dayOfWeek = "SUN";
					break;
			}

			return dayOfWeek;
		}
	}
}
