﻿using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] _tbl = {
				{"Генчо","Генчев","19"},
				{"Цветан","Василев","55"},
				{"Бойко","Борисов","60"},
				{"Гергана","Маринова","33"},
				{"Петя","Неделчева","25"},
				{"Григор","Димитров","26"}
			};
			Console.WriteLine ("Име".PadRight(12)+"Фамилия".PadRight(12)+"Години".PadRight(12));
			Console.WriteLine ("==============================");

		//Пример с цикъл for
//		for (int i = 0; i < _tbl.Length/3 ; i++) {
////				//Код на цикъла
//				for (int j=0; j<3; j++){
//					Console.Write(_tbl[i,j].PadRight(12));
//				}
//				Console.WriteLine();
//			}

		//Пример с while
//			int i=0;
//			while (i<_tbl.Length/3)
//			{
//				Console.WriteLine (
//					_tbl[i,0].PadRight(12)+
//					_tbl[i,1].PadRight(12)+
//					_tbl[i,2].PadRight(12));
//				i++;
//			}

			//Пример с do ...  while
			int i=0;
			do {
				Console.WriteLine (
					_tbl [i, 0].PadRight (12) +
					_tbl [i, 1].PadRight (12) +
					_tbl [i, 2].PadRight (12));
				i++;
			} while(i < _tbl.Length/3);

			Console.WriteLine ("\n\n\nPress any key...");
			Console.ReadKey ();
		}
	}
}
