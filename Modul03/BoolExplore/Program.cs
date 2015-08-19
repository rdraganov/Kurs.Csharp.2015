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

			bool _check01=_ui<=_i.Length;
			bool _check02=_ui>0;

			bool _exp01 = _check01 && _check02; 	//Логическо И *&&Ч
//			bool _exp02 = _check01 || _check02;		//Логическо ИЛИ *||*
//			bool _exp03 = !_check01;				//Логическо НЕ *!*
//
//			Console.WriteLine ("Логическо И: "+_exp01);
//			Console.WriteLine ("Логическо ИЛИ: "+_exp02);
//			Console.WriteLine ("Логическо НЕ за "+_check01+"   "+ _exp03+"\n\n");

			if (_exp01)
			{
				Console.WriteLine ("Елемент номер "+(int)_ui +" : "+ (int)_i[_ui-1]);
			}
			if (!_check01)
			{
				Console.WriteLine ("Индексът е прекалено голям \n\n\n");
			}
			if (!_check02)
			{
				Console.WriteLine ("Индексът трябва да е по-голям от нула\n\n\n");
			}
			//Console.WriteLine ("Елемент номер "+(int)_ui +" : "+ (int)_i[_ui-1]);


		}
	}
}
