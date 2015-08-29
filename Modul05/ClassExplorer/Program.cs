using System;

namespace ClassExplorer
{
	public class person
	{
		public string simpleString="Тестова променлива от клас";
		public person()
		{
			simpleString="Промяна при инициализация";
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниране на клас
			person _person = new person ();

			//използване на клас
			Console.WriteLine (_person.simpleString);
		}
	}
}
