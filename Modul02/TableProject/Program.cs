﻿using System;

namespace TableProject
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на таблица
			string[,] table = new string[2,3];

			//Въвеждане на първи ред
			table[0,0]="Иван"; table[0,1]="Петров"; table[0,2]="37";
			//Въвеждане на втори ред
			table[1,0]="Стоян"; table[1,1]="Димитров"; table[1,2]="51";

			//Отпечатване
			Console.Write("Кой ред да отпечатам? > ");
			int _Index=Convert.ToInt32(Console.ReadLine())-1;

			Console.WriteLine(table[_Index,0][0]+". "+table[_Index,1]+", "+table[_Index,2]+" г.");


		}
	}
}

//string[] row = new string[3];
//row[0]="Ред 1";
//row[1]="Ред 2";
//row[2]="Ред 3";
//
//Console.WriteLine("Масив row: "+row[0]+", "+row[1]+", "+row[2]+"\n");
//
//string ps = "1,2,3,4,5,6,7,8,9";
//string[] parse = ps.Split (',');
//Console.WriteLine ("Броят на елементите в масива " + ps + "\n\ne: " + parse.Length);
//
//string list1 = string.Join (";", parse);
//Console.WriteLine ("Новият стринг е: \n"+list1+"\n\n");