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

				if (_userinput.ToLower().Contains("add")){
					int _add=0;
					try{
						if (int.TryParse(_userinput.Split(' ')[1], out _add))
							{
								_list.Add(_add);
							}
					}catch{ Console.WriteLine("Неуспешно добавяне");
					}
				}
				//Преглед на списъка List
				if (_userinput.ToLower().Contains("show")){
					Console.Write("List: ");
					for (int i=0; i<_list.Count; i++)
					{
						Console.Write(_list[i]);
						if (i < _list.Count -1) Console.Write(", ");
					}
					Console.WriteLine("\n");
				}
				//Размер на списъка
				if (_userinput.ToLower().Contains("size")){
					Console.WriteLine("Размер на списъка: "+_list.Count.ToString()+"\n");
				}
			} while(_userinput != "exit");
		}
	}
}
