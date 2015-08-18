using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// bool _b = true;
			// bool _a = 5 > 10;
			int[] _i = new int[] {22,12,34};

			Console.Write("Въведете номер: ");
			int _ui=Convert.ToInt32(Console.ReadLine());

			bool _check01=_ui<=3;
			bool _check02=_ui>0;


			Console.WriteLine (_i[_ui-1]);
		}
	}
}
