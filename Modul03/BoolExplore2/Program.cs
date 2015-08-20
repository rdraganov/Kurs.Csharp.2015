using System;

namespace BoolExplore2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] _i = new int[] {22,12,34};

			Console.Write("Въведете индекс: ");
			int _ui = 0;
			string _input = "0";
			_input=Console.ReadLine();

			bool _check01 = int.TryParse( _input, out _ui );

			_ui = (_ui <= _i.Length ) ? _ui : 3;
			_ui = (_ui > 0) ? _ui : 1;

			if (_check01)
			{
				Console.WriteLine ("Елемент с индекс "+(int)_ui +" : "+ (int)_i[_ui-1]);
			}

		}
	}
}
