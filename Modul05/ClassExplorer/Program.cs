using System;

namespace ClassExplorer
{
	public class person
	{
		public string simpleString="Тестова променлива от клас";
		private string hiddenString="";
		public string user="";
		public person(string _ini)
		{
			if (_ini == "password1")
				hiddenString = "Потребител 1";
			if (_ini == "password2")
				hiddenString = "Потребител 2";
			user = hiddenString;
			if (hiddenString.Length > 0)
				simpleString="Добре дошли отново, "+user+"!";
			else
				simpleString="Вие нямате достъп до програмата!";
		}
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Парола: "); string _user = Console.ReadLine ();
			//Дефиниране на клас
			person _person = new person (_user);

			//използване на клас
			Console.WriteLine (_person.simpleString);
		}
	}
}
