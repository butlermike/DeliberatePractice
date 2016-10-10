using System;

namespace STRHH
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// Get number of test cases
			var inputstring = Console.ReadLine();
			int testcases = int.Parse(inputstring.Trim());

			for (int caseindex = 1; caseindex <= testcases; caseindex += 1)
			{
				bool printit = true;
				string inputcase = Console.ReadLine().Trim();
				var inputArray = inputcase.ToCharArray();

				int loopsize = (int)(inputcase.Length / 2);

				for (int idx0 = 0; idx0 < loopsize; idx0 += 1)
				{
					if (printit)
					{
						Console.Write(inputArray[idx0]);
					}
					printit = !printit;
				}
				Console.WriteLine("");
			}
		}
	}
}