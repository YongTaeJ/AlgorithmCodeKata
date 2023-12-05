using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _59
	{
		public int solution(int n, int m, int[] section)
		{
			// n은 벽의 길이, m은 롤러의 길이
			// section은 칠해야 하는 벽의 위치

			int count = 0;
			int sectionIdx = 0;
			int answer = 0;

			while(count <= n && sectionIdx < section.Length)
			{
				int value = section[sectionIdx++];
				if(count > value)
				{
					// 이미 색칠되었으니 넘어가기
					continue;
				}

				// 색칠이 안됐으니 진행
				count = value + m;
				answer++;
			}

			return answer;
		}
	}
}
