using System;

namespace Modul05
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Дефиниции
			string usercommand="";

			//Потребителски команди
			do {
				Console.WriteLine("$ "); usercommand=Console.ReadLine();
				if (usercommand.ToLower().Contains("t2")) test2(usercommand);
				if (usercommand.ToLower().Contains("t3")) Console.WriteLine(
					"Резултатът е: "+test3(usercommand).ToString());

			} while(usercommand != "exit");
		}

		public static void test2(string _input)
		{
			try{
				double _temp=0;
				if (double.TryParse(_input.Split(' ')[1], out _temp))
				{
					Console.WriteLine("\nРезултат от "+_temp.ToString()+"^2: "+(_temp*_temp).ToString());
				}
			}catch{}
		}
		public static int test3 (string _input)
		{
			int _temp=0;
			if (int.TryParse(_input.Split(' ')[1], out _temp))
			{
				_temp = _temp * _temp * _temp;
			}
			return(_temp);
		}
		
	  }
	
}
