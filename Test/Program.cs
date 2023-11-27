namespace Test
{
	internal class Program
	{
		static void Main(string[] args)
		{
			_47 adf = new _47();
			string[] str = { "abce", "abcd", "cdx" };
			str = adf.solution(str, 1);

			Console.WriteLine(str[0]);
			Console.WriteLine(str[1]);
			Console.WriteLine(str[2]);
		}
	}
}