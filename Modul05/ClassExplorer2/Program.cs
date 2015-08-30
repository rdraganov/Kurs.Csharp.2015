using System;

namespace ClassExplorer2
{
	public class person
	{
		private string _userName="";
		private string _userPass="";

		private string _userID= "";
		private string _userFname = "";
		private string _userLname = "";

		public person(string _user, string _pass)
		{
			checkUser (_user, _pass);
		}

		public string userName
		{
			get{ return _userName; }
		}

		public string userPass
		{
			get{ return _userPass; }
		}

		public string userID
		{
			get{return _userID;}
			set{ _userID = value; }
		}

		public string userFname
		{
			get{return _userFname;}
			set{ _userFname = value; }
		}

		public string userLname
		{
			get{return _userLname;}
			set{ _userLname = value; }
		}

		private bool checkUser(string _user, string _pass)
		{
			if (_user == "user" && _pass == "pass") {
				_userName = _user; _userPass = _pass;
				//попълване на пропърти
				userID="ID 242541";
				userFname = "Румен";
				userLname = "Драганов";
				return true;
			}
			return false;
		}

	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			Console.Write ("Потребител: "); 	string _user = Console.ReadLine ();
			Console.Write ("Парола: "); 		string _pass = Console.ReadLine ();
			//Дефиниране на клас
			person _person = new person (_user,_pass);

			Console.WriteLine (_person.userFname + " " + _person.userLname);

			//използване на клас
			//Console.WriteLine (_person.getWelcomeMessage());

		}
	}
}
