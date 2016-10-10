using System;
using System.Collections;
using System.Collections.Generic;

namespace DivSum
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<uint> resultList = new List<uint>();
			try
			{
				string inputline = Console.ReadLine().Trim();
				uint inputvalue = UInt32.Parse(inputline);
				uint inputsize = inputvalue;

				for (var index1 = 0; index1 < inputsize; index1 += 1)
				{
					inputline = Console.ReadLine().Trim();
					inputvalue = UInt32.Parse(inputline);

					uint theSum = 1;
					uint temp = 0;

					uint limit = (uint)Math.Sqrt(inputvalue);
					if (inputvalue == 1)
					{
						theSum = 0;
					}

					//Console.WriteLine("Processing [" + inputvalue + "] to [" + limit + "]");
					for (uint i = 2; i <= limit; i += 1)
					{
						temp = 0;
						if (inputvalue % i == 0)
						{
							//Console.WriteLine();
							//Console.Write("Adding divisor [" + i + "]");
							theSum += i;
							temp = inputvalue / i;
							if (i != temp)
							{
								//Console.Write(", Adding divisor [" + temp + "]");
								theSum += temp;
							}
						}
					}
					//Console.WriteLine(", Sum [" + theSum + "]");
					resultList.Add(theSum);
				}
				foreach (var result in resultList)
				{
					Console.WriteLine(result);
				}

			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
			}

		}
	}
}
