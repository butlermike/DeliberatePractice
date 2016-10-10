using System;

namespace LifeUniversEverything
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			while (true)
			{
				var inputstring = Console.ReadLine().Trim();
				var inputvalue = Int32.Parse(inputstring);

				if (inputvalue == 42)
				{
					break;
				}
				Console.WriteLine(inputvalue);
			}
		}
	}
}
