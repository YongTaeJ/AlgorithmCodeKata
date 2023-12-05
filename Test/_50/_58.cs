using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	internal class _58
	{
		public int solution(int[] nums)
		{
			// 1. 숫자를 3개씩 묶어서 더한다
			// 2. 더한 수가 소수가 맞는지 판단한다
			// 3. 소수면 answer++
			int sum;
			int first, second;
			int answer = 0;
			bool isPrime;
			for(int i=0; i<nums.Length-2; i++)
			{
				first = nums[i];
				for(int j = i+1; j <nums.Length-1; j++)
				{
					second = nums[j];
					for(int k = j+1; k < nums.Length; k++)
					{
						isPrime = true;
						sum = first + second + nums[k];
						for(int val = 2; val < sum; val++)
						{
							if(sum % val == 0)
							{
								isPrime = false;
							}
						}
						if (isPrime) answer++;
					}
				}
			}

			return answer;
		}
	}
}
