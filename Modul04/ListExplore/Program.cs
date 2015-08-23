using System;
using System.Collections.Generic;

namespace ListExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string _userinput="";
			List<int> _list = new List<int> ();

			_list.Add (14);
			_list.Add (42);
			_list.Add (33);

			//Потребителски вход
			do {
				Console.Write ("> ");
				_userinput = Console.ReadLine ();

				//Добавяне на елемент в списъка List

				//Преглед на списъка List
				if (_userinput.Contains("show")){
					Console.Write("List: ");
					for (int i=0; i<_list.Count; i++)
					{
						Console.Write(_list[i]);
						if (i < _list.Count -1) Console.Write(", ");
					}
					Console.WriteLine();
				}
				//Размер на списъка List

			} while(_userinput != "exit");
		}
	}
}
