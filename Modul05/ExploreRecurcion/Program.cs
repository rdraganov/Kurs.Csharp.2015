using System;

namespace ExploreRecurcion
{
	
	class MainClass
	{
		public static int fact(int _fact)
		{
			if (_fact<=1) return _fact;
			else return _fact*fact(_fact-1);
		}
		public static void Main (string[] args)

		{
			Console.WriteLine(fact(3));
			Console.WriteLine(fact(4));
			Console.WriteLine(fact(5));
			Console.WriteLine(fact(6));
			Console.WriteLine(fact(7));

		}
	}
}
