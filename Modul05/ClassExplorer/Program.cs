using System;

namespace ClassExplorer
{
	public class person
	{
		private string simpleString="Тестова променлива от клас";
		private string hiddenString="";
		private string user="";
		public person(string _ini)
		{
			getUser (_ini);
			setWelcomeMessage ();
		}
		private void getUser(string _ini)
		{
			if (_ini == "password1")
				hiddenString = "Потребител 1";
			if (_ini == "password2")
				hiddenString = "Потребител 2";
			user = hiddenString;
		}
		private void setWelcomeMessage()
		{
			if (hiddenString.Length > 0)
				simpleString="Добре дошли отново, "+user+"!";
			else
				simpleString="Вие нямате достъп до програмата!";
		}
		public string getWelcomeMessage ()
		{
			return(simpleString);
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
			Console.WriteLine (_person.getWelcomeMessage());
		}
	}
}
