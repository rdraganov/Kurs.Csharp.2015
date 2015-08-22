using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] _tbl = {"Генчо","Пенчо","Атанас","и аз"};
			Console.WriteLine ("Име");
			Console.WriteLine ("==========");
			for (int i = 0; i < _tbl.Length ; i++) {
				//Код на цикъла
				Console.WriteLine (_tbl[i]);
			}
			Console.WriteLine ("\n\n\n");
			Console.ReadKey ();
		}
	}
}
