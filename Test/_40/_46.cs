using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _46
	{
		public int solution(string s)
		{
			StringBuilder wordBuilder = new StringBuilder();
			StringBuilder answerBuilder = new StringBuilder();

			char tmpChar = 'A';

			foreach(char c in s)
			{
				if(c >= 'a' && c <= 'z')
				{
					wordBuilder.Append(c);
					if (IsWord(wordBuilder.ToString(), ref tmpChar))
					{
						wordBuilder.Clear();
						answerBuilder.Append(tmpChar);
					}
				}

				if(c >= '0' && c <= '9')
				{
					answerBuilder.Append(c);
				}
			}

			int answer = int.Parse(answerBuilder.ToString());
			return answer;
		}

		public bool IsWord(string str, ref char c)
		{
			bool isWord = true;

			switch(str)
			{
				case "zero":
					{
						c = '0';
						break;
					}
				case "one":
					{
						c = '1';
						break;
					}
				case "two":
					{
						c = '2';
						break;
					}
				case "three":
					{
						c = '3';
						break;
					}
				case "four":
					{
						c = '4';
						break;
					}
				case "five":
					{
						c = '5';
						break;
					}
				case "six":
					{
						c = '6';
						break;
					}
				case "seven":
					{
						c = '7';
						break;
					}
				case "eight":
					{
						c = '8';
						break;
					}
				case "nine":
					{
						c = '9';
						break;
					}
				default:
					isWord = false;
					break;
			}

			return isWord;
		}
	}
}
