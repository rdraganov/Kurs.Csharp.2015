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
				Console.Write("$ "); usercommand=Console.ReadLine();
				if (usercommand.ToLower().Contains("t2")) test2(usercommand);
				if (usercommand.ToLower().Contains("t3")) Console.WriteLine(
					"Резултатът  a . a . a = : "+test3(usercommand).ToString());
				if (usercommand.ToLower().Contains("t4")) 
				{ double _a=0;
					if (test4(usercommand,out _a))
						{
							Console.WriteLine("a . a = " +_a.ToString());				}
				}
				if (usercommand.ToLower().Contains("t5")) 
				{ double _t=5, _c=-1;
					if (test5(ref _t))
					{
						Console.WriteLine(_t);	
					}
					if (test5(ref _c))
					{
						Console.WriteLine(_c);	
					}
				}
				if (usercommand.ToLower().Contains("t6"))
				{
					Console.WriteLine("Брой четни числа: "+test6(usercommand).Length.ToString());
				}
				

			} while(usercommand != "exit");
		}

		public static void test2(string _input)
		{
			try{
				double _temp=0;
				if (double.TryParse(_input.Split(' ')[1], out _temp))
				{
					Console.WriteLine("\nРезултат от "+_temp.ToString()+"^2: "+(_temp*_temp).ToString());
				} else {Console.WriteLine("Командата не е коректна");}
			}catch{}
		}
		public static int test3 (string _input)
		{
			int _temp=0;
			if (int.TryParse (_input.Split (' ') [1], out _temp)) {
				_temp = _temp * _temp * _temp;
			} else {
				Console.WriteLine("Командата не е коректна");
			}
			return(_temp);
		}

		public static bool test4(string _input, out double _i)
		{
			try{
				string _p=_input.Split(' ')[1];
				double __p=0;
				if (double.TryParse(_p, out __p))
					{
						_i=__p*__p;
						return true;
				}else{
					Console.WriteLine("Командата не е коректна");
				}

			}catch{
			}
			_i = 0;
			return false;
		}

		public static bool test5(ref double _i)
		{
			double temp = _i;
			_i = _i * _i;
			return(temp > 0);
		}


		public static string[] test6(string _input)
		{
			try{
				int _border=0;
				string _temp="";
				if (int.TryParse(_input.Split(' ')[1],out _border))
					{
						for (int i=0; i < _border; i++)
						{
						if (i % 2 == 0) 
						{
							_temp+=i.ToString();
							if (i < _border-2) _temp+=",";
						}
					}
					Console.WriteLine(_temp); //за проверка
					return _temp.Split(',');
					}
			}catch{
			}
			return new string[1] {"0"};
		}

	  }
	
}
